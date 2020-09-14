using System;
using System.Collections.Generic;

namespace ch01_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a series of number separated by space:");

            try
            {
                string[] numStr = Console.ReadLine().Split();
                List<int> numList = new List<int>();
                foreach (string str in numStr)
                {
                    numList.Add(Convert.ToInt32(str));
                }

                Statistic(numList.ToArray(), out int maxNum, out int minNum, out float meanNum, out int sum);
                Console.WriteLine($"MaxNum: {maxNum}\tMinNum: {minNum}\tMeanNum: {meanNum}\tSum: {sum}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void Statistic(int[] numList, out int maxNum, out int minNum, out float meanNum, out int sum)
        {
            maxNum = numList[0];
            minNum = numList[0];
            sum = 0;
            for (int i = 0; i < numList.Length; i++)
            {
                if (numList[i] > maxNum)
                {
                    maxNum = numList[i];
                }
                else if (numList[i] < minNum)
                {
                    minNum = numList[i];
                }
                sum += numList[i];
            }
            meanNum = (float)sum / numList.Length;
        }
    }
}
