using System;
using System.Linq;
namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] condensed = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length - i - 1; j++)
                {
                    condensed[j] = numbers[j] + numbers[j + 1];
                    numbers[j] = condensed[j];
                }
            }
            if (numbers.Length == 1)
            {
                Console.WriteLine(numbers[0]);
            }
            else
            {
                Console.WriteLine(condensed[0]);
            }
        }
    }
}
