using System;
using System.Collections.Generic;

namespace ch01_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input an integer:");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Prime Factors:");
            List<int> primeFactors = GetPrimeFactor(num);
            primeFactors.ForEach(f => Console.WriteLine(f));
        }

        static List<int> GetPrimeFactor(int num)
        {
            List<int> primeFactors = new List<int>();

            for (int factor = 2; factor * factor <= num; factor++)  // 因式分解法
            {
                while(num % factor == 0)
                {
                    primeFactors.Add(factor);
                    num /= factor;
                }
            }
            if (num != 1)
            {
                primeFactors.Add(num);
            }

            return primeFactors;
        }
    }
}
