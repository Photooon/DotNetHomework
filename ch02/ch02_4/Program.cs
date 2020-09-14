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
            clock.Alarm += Alarmed;
            clock.Tick += ClockTick;
            clock.CheckPoint = 5;      // 设定倒计时：15秒
            clock.Start();

            Console.Read();
        }

        static private void ClockTick(TickEventArg tickEventArg)
        {
            Console.WriteLine($"Time: {tickEventArg.checkpoint}");
        }

        static private void Alarmed()
        {
            Console.WriteLine("Clock alarmed!");
        }
    }
}
