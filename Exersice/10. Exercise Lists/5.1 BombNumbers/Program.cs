using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._1_BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                  .Split()
                  .Select(int.Parse)
                  .ToList();

            List<int> bombNumbers = Console.ReadLine()
                   .Split()
                   .Select(int.Parse)
                   .ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombNumbers[0])
                {
                    BlowUpNumbers(numbers, bombNumbers, i);
                }
            }
            Console.WriteLine(numbers.Sum());
        }

        private static void BlowUpNumbers(List<int> numbers, List<int> bombNumbers, int i)
        {
            int start = Math.Max(0, i - bombNumbers[1]);
            int end = Math.Min(numbers.Count -1, i + bombNumbers[1]);

            for (int j = start; j <= end; j++)
            {
                numbers[j] = 0;
            }
        }
    }
}
