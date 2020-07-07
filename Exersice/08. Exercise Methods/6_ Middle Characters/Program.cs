using System;

namespace _6__Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PrintMidleChar(input);
        }
        static void PrintMidleChar(string input)
        {
            if (input.Length % 2 == 0)
            {
                char firstChar = input[input.Length / 2];
                char secondChar = input[input.Length / 2 - 1];
                Console.WriteLine($"{secondChar}{firstChar}");
            }
            else
            {
                char midChar = input[input.Length / 2];
                Console.WriteLine(midChar);
            }
        }

    }
}
