using System;

namespace ch01_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            while(true)
            {
                Console.WriteLine("Please input two numbers separated by space:");
                string inputStr = Console.ReadLine().Trim();
                try
                {
                    string[] numStr = inputStr.Split(' ');
                    if (numStr.Length != 2)
                    {
                        Console.WriteLine("Illegal input, you may give more than two numbers " +
                            "or separated the number with wrong character.");
                    }
                    else
                    {
                        num1 = Convert.ToInt32(numStr[0]);
                        num2 = Convert.ToInt32(numStr[1]);
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            bool inputFlag = false;
            do
            {
                Console.WriteLine("Please input a operator:");
                string operatorStr = Console.ReadLine().Trim('\n');
                switch (operatorStr)
                {
                    case "+":
                        Console.WriteLine(string.Format("{0} + {1} = {2}", num1, num2, num1 + num2));
                        break;
                    case "-":
                        Console.WriteLine(string.Format("{0} - {1} = {2}", num1, num2, num1 - num2));
                        break;
                    case "*":
                        Console.WriteLine(string.Format("{0} * {1} = {2}", num1, num2, num1 * num2));
                        break;
                    case "/":
                        Console.WriteLine(string.Format("{0} / {1} = {2}", num1, num2, num1 / num2));
                        break;
                    default:
                        Console.WriteLine("Illegal operator.");
                        inputFlag = true;
                        break;
                }
            } while (inputFlag);
        }
    }
}
