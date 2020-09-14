using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;

namespace ch02_4
{
    public delegate void TickEventHandler(object sender, TickEventArg tickEventArg);
    public delegate void AlarmEventHandler(object sender, EventArgs eventArgs);

    public class TickEventArg : EventArgs
    {
        public int checkPoint;

        public TickEventArg(int checkPoint)
        {
            this.checkPoint = checkPoint;
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

        public void Close()
        {
            timer.Stop();
        }

        private void Check(object sender, System.Timers.ElapsedEventArgs e)
        {
            checkCount += 1;
            Tick(this, new TickEventArg(checkCount));
            if (checkCount == checkPoint)
            {
                Alarm(this, new EventArgs());
                checkPoint = -1;
            }
        }
    }
}
