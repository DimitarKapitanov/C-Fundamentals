using System;
using System.Linq;

namespace _2._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split()
                .ToArray();

            int result = SumResult(input);

            Console.WriteLine(result);
        }

        private static int SumResult(string[] input)
        {
            int result = 0;
            string first = input[0];
            string second = input[1];

            if (first.Length > second.Length)
            {

                for (int i = 0; i < second.Length; i++)
                {
                    result += first[i] * second[i];
                }

                for (int i = second.Length; i < first.Length; i++)
                {
                    result += first[i];
                }
            }
            else if (first.Length < second.Length)
            {
                for (int i = 0; i < first.Length; i++)
                {
                    result += first[i] * second[i];
                }

                for (int i = first.Length; i < second.Length; i++)
                {
                    result += second[i];
                }
            }
            else
            {
                for (int i = 0; i < first.Length; i++)
                {
                    result += first[i] * second[i];
                }
            }

            return result;
        }
    }
}
