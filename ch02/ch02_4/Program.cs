using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch02_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            clock.Alarm += (S, E) => { Console.WriteLine("Alarmed!"); };
            clock.Tick += (S, E) => { Console.WriteLine($"Time: {E.checkPoint}"); };
            clock.CheckPoint = 5;      // 设定倒计时：5秒
            clock.Start();

            Console.Read();
        }
    }
}
