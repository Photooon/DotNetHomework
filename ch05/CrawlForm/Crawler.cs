using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrawlForm
{
    class Crawler
    {
        public event Action<Crawler, int, string, string> HtmlDownloaded;
        public event Action<Crawler> Stopped;

        public string InitUrl { get; set; } // 起始网址
        public int MaxNum { get; set; }     // 最大下载数量
        public bool StopSema { get; set; }  // 立刻终止爬取信号

        private Hashtable urls = Hashtable.Synchronized(new Hashtable());       // 线程安全的Hashtable，存储所有url
        private ConcurrentQueue<string> waitingUrls = new ConcurrentQueue<string>();

        public Crawler()
        {
            MaxNum = 20;
            StopSema = false;

            if (!Directory.Exists("./htmls/"))          // 创建一个存储html的文件夹
            {
                Directory.CreateDirectory("./htmls/");
            }
        }

        public void Start()
        {
            urls = urls = Hashtable.Synchronized(new Hashtable());
            waitingUrls = new ConcurrentQueue<string>();

            waitingUrls.Enqueue(InitUrl);

            List<Task> tasks = new List<Task>();
            int completedNum = 0;
            HtmlDownloaded += (crawler, indexer, urls, info) => { completedNum++; };

            while(tasks.Count < MaxNum)
            {
                if (StopSema)
                {
                    break;
                }

                if (!waitingUrls.TryDequeue(out string url))
                {
                    if (completedNum < tasks.Count)         // 队列已经空了，但是还有任务未结束时，可能队列还会添加新的url，等待任务
                    {
                        continue;
                    }
                    else                                    // 队列已经空了，且没有任务未完成时，说明已经爬完了，直接退出
                    {
                        break;
                    }
                }

                int index = tasks.Count + 1;
                Task task = Task.Run(() => Process(url, index));
                tasks.Add(task);
            }

            Task.WaitAll(tasks.ToArray());
            Stopped(this);
        }

        private void Process(string url, int index)
        {
            try
            {
                string html = Download(url, index);             // 下载html
                urls[url] = true;

                if (html == null) return;

                Parse(url, html);                               // 解析新的url
                HtmlDownloaded(this, index, url, "Success");
            } 
            catch (Exception e)
            {
                HtmlDownloaded(this, index, url, "Error: " + e.Message);
            }
        }

        private string Download(string url, int index)
        {
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            string html = client.DownloadString(url);

            if (html == null)
            {
                throw new Exception("下载结果为空");
            }

            File.WriteAllText($"./htmls/{index++}.html", html);    // 保存到本地
            return html;
        }

        private void Parse(string url, string html)
        {
            string strRef = @"(href|HREF)\s*=\s*[""'](?<url>[^""'#>]+)[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);

            foreach (Match match in matches)
            {
                string newUrl = match.Groups["url"].Value;
                strRef = @"(.html|.htm|.jsp|.aspx|.php|/[\w\d]+/?)$";   // 只爬取网页和二级目录
                if (newUrl.Length == 0) continue;
                if (!Regex.IsMatch(newUrl, strRef)) continue;       // 匹配是否为html，htm，jsp，aspx、php页面

                newUrl = TransUrl(newUrl, url);                     // 修正相对地址

                if (urls[newUrl] == null)                           // 未爬取过时记录一下并加入等待队列
                {
                    urls[newUrl] = false;
                    waitingUrls.Enqueue(newUrl);
                }
            }
        }

        private string TransUrl(string url, string current)         // 将相对路径转为绝对路径
        {   
            if (url.StartsWith("//"))
            {
                url = "https:" + url;
            }

            if (url.StartsWith("/"))
            {
                url = InitUrl + url.Substring(1, url.Length - 1);   // 拼接起始地址
            }

            if (url.StartsWith("./"))
            {
                url += url.Substring(2, url.Length - 2);            // 拼接当前地址
            }

            if (url.StartsWith("../"))
            {
                do
                {
                    current = Regex.Replace(current, @"/([^/]*)$", "/");   // 删去尾部一节
                    url = url.Substring(3, url.Length - 3);
                } while (url.StartsWith("../"));
                url = current + url;
            }

            return url;
        }
    }
}
