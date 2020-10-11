using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrawlForm
{
    public partial class CrawlForm : Form
    {
        private Crawler crawler = new Crawler();

        public CrawlForm()
        {
            InitializeComponent();

            crawler.Stopped += CrawlerStopped;
            crawler.HtmlDownloaded += HtmlDownloaded;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            crawler.InitUrl = initUrlTextBox.Text;

            Thread thread = new Thread(new ThreadStart(crawler.Start));
            thread.Start();
            outputTextBox.Text = "爬虫已启动...\r\n";
        }

        private void HtmlDownloaded(Crawler crawler, int index, string url, string info)
        {
            string msg = $"{index}\t{url}\t{info}\r\n";
            Action action = () => { outputTextBox.AppendText(msg); };

            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
        }

        private void CrawlerStopped(Crawler crawler)
        {
            string msg = $"爬虫已终止...\r\n";
            Action action = () => { outputTextBox.AppendText(msg); };

            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            crawler.StopSema = true;
        }
    }
}
