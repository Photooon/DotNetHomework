using System;
using System.Collections.Generic;

namespace ch01_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input an upper number:");
            List<int> primeNum = FilterPrime(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Prime Number:");
            primeNum.ForEach(f => Console.WriteLine(f));
        }

        static List<int> FilterPrime(int upper)
        {
            List<int> primeNum = new List<int>();
            bool[] isPrime = new bool[upper + 1];       // 表示从0->upper是否为素数
            for (int i = 2; i < upper - 1; i++)
            {
                isPrime[i] = true;
            }

            for (int i = 2; i < upper + 1; i++)
            {
                if (!isPrime[i]) { continue; }

                primeNum.Add(i);
                for (int j = 2 * i; j < upper + 1; j += i)     // 除去倍数
                {
                    isPrime[j] = false;
                }
            }

            return primeNum;
        }
    }
}
