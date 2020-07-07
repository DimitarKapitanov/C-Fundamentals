using System;

namespace _7._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            string result = RepeatSting(input, count);
            Console.WriteLine(result);
        }

        static string RepeatSting(string input, int count)
        {
            string result = "";

            for (int i = 0; i < count; i++)
            {
                result += input;
            }
            return result;
        }
    }
}
