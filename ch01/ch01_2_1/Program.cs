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
            List<int> primeFactors = GetPrimeNumDivisor(num);
            primeFactors.ForEach(f => Console.WriteLine(f));
        }

        static List<int> GetPrimeNumDivisor(int num)
        {
            List<int> primeFactors = new List<int>();

            for (int i = 2; i <= num; i++)
            {
                if (num % i == 0 && IsPrimeNum(i))
                {
                    primeFactors.Add(i);
                }
            }

            return primeFactors;
        }

        static bool IsPrimeNum(int num)
        {
            bool isPrimeNum = true;
            for(int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    isPrimeNum = false;
                    break;
                }
            }

            return isPrimeNum;
        }
    }
}
