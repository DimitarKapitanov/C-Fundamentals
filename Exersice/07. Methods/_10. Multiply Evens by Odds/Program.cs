using System;
using System.Linq;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            string digits = Console.ReadLine();
            int[] num = new int[digits.Length];

            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] == '-')
                {
                    continue;
                }
                else
                {
                    num[i] = int.Parse(digits[i].ToString());
                }
            }
            PrintSumOfEvenAndOdd(num);
        }

        static void PrintSumOfEvenAndOdd(int[] num)
        {
            int evenResult = GetSumOfEven(num);
            int oddResult = GetSumOfOdd(num);
            Console.WriteLine(evenResult * oddResult);
        }

        static int GetSumOfOdd(int[] num)
        {
            int result = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 != 0)
                {
                    result += num[i];
                }
            }
            return result;
        }

        static int GetSumOfEven(int[] num)
        {
            int result = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 0)
                {
                    result += num[i];
                }
            }
            return result;
        }
    }
}
