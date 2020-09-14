using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;

namespace ch02_4
{
    public delegate void TickEventHandler(TickEventArg tickEventArg);
    public delegate void AlarmEventHandler();

    public class TickEventArg
    {
        public int checkpoint;

        public TickEventArg(int checkPoint)
        {
            this.checkpoint = checkPoint;
        }
    }

    class Clock
    {
        public event TickEventHandler Tick;
        public event AlarmEventHandler Alarm;

        public int CheckPoint 
        {
            set
            {
                if (value > 0)
                {
                    checkPoint = value;
                    checkCount = 0;
                }
            }
        }

        private readonly Timer timer;
        private int checkPoint;
        private int checkCount;

        public Clock()
        {
            checkCount = 0;
            timer = new Timer(1000);    // 最小检查单位为秒
            timer.Elapsed += new ElapsedEventHandler(Check);
            timer.AutoReset = true;
        }

        public void Start()
        {
            timer.Start();
        }

        private void Check(object sender, System.Timers.ElapsedEventArgs e)
        {
            checkCount += 1;
            Tick(new TickEventArg(checkCount));
            if (checkCount == checkPoint)
            {
                Alarm();
                checkCount = 0;
            }
        }
    }
}
