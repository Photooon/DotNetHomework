using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ch02_1.Shapes;
using ch02_2.BeanFactory;

namespace ch02_2.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();
            List<Shape> shapeList = new List<Shape>();

            for(int i = 0; i < 10; i++)
            {
                shapeList.Add(factory.GetRandomShape());
            }

            double sum = 0;
            shapeList.ForEach(s => sum += s.Area);
            Console.WriteLine(sum);
        }
    }
}
