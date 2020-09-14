using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch02_1.Shapes
{
    public abstract class Shape
    {
        abstract public bool Legal { get; }

        abstract public double Area { get; }
    }

    public class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public override bool Legal 
        { 
            get
            {
                if (Length > 0 && Width > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public Rectangle()
        {
            Random random = new Random();
            do
            {
                this.Length = random.NextDouble() * 100;
                this.Width = random.NextDouble() * 100;
            } while (!this.Legal);
        }

        public override double Area
        {
            get
            {
                if (!this.Legal) { return -1; }

                return Length * Width;
            }
        }

        public Rectangle(double Length, double Width)
        {
            this.Length = Length;
            this.Width = Width;
        }
    }

    public class Square : Rectangle
    {
        public double Side
        {
            set
            {
                this.Length = value;
                this.Width = value;
            }
        }

        public Square() : base()
        {  
            this.Width = this.Length;
        }

        public Square(double side): base(side, side){ }
    }

    public class Triangle : Shape
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public Triangle()
        {
            Random random = new Random();
            do
            {
                this.Side1 = random.NextDouble() * 100;
                this.Side2 = random.NextDouble() * 100;
                this.Side3 = random.NextDouble() * 100;
            } while (!this.Legal);
        }

        public Triangle(double Side1, double Side2, double Side3)
        {
            this.Side1 = Side1;
            this.Side2 = Side2;
            this.Side3 = Side3;
        }

        public override double Area
        {
            get
            {
                if (!this.Legal) { return -1; }

                double p = (Side1 + Side2 + Side3) / 2;
                return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));      // 海伦公式
            }
        }

        public override bool Legal
        {
            get
            {
                if (Side1 > 0 && Side2 > 0 && Side3 > 0 &&
                    Side1 + Side2 > Side3 &&
                    Side1 + Side3 > Side2 &&
                    Side2 + Side3 > Side1)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
