using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Bomb_Numbers
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
                    blowUpNumbers(numbers, bombNumbers, i);
                }
            }
            Console.WriteLine(numbers.Sum());
        }

        private static void blowUpNumbers(List<int> numbers, List<int> bombNumbers, int i)
        {
            RotateRight(numbers, bombNumbers, i);
            RotateLeft(numbers, bombNumbers, i);
        }

        private static void RotateLeft(List<int> numbers, List<int> bombNumbers, int i)
        {
            int start = i;
            int countNumbers = bombNumbers[1];
            for (int j = start; j >= 0; j--)
            {
                numbers[i] = 0;
                if (countNumbers != 0)
                {
                    if (j - 1 < 0 || countNumbers <= 0)
                    {
                        break;
                    }
                    numbers[j - 1] = 0;
                }
                countNumbers--;
            }
        }

        private static void RotateRight(List<int> numbers, List<int> bombNumbers, int i)
        {
            int start = i;
            int countNumbers = bombNumbers[1];
            for (int j = start; j < numbers.Count; j++)
            {
                numbers[i] = 0;
                if (countNumbers != 0)
                {
                    if (j + 1 == numbers.Count || countNumbers <=0)
                    {
                        break;
                    }
                    numbers[j + 1] = 0;
                }
                countNumbers--;
            }
        }
    }
}
