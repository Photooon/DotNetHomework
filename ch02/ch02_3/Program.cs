using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ch02_3.GenericList;

namespace ch02_3
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> myList = new GenericList<int>();
            myList.Add(10);
            myList.Add(5);
            myList.Add(-1);

            myList.ForEach(d => Console.WriteLine(d));

            int maxNum = int.MinValue;
            int minNum = int.MaxValue;
            long sum = 0;
            myList.ForEach(d => {
                if (d >= maxNum) maxNum = d;
                if (d <= minNum) minNum = d;
                sum += d;
            });
            Console.WriteLine(string.Format("max: {0}\tmin: {1}\tsum: {2}", maxNum, minNum, sum));
        }
    }
}
