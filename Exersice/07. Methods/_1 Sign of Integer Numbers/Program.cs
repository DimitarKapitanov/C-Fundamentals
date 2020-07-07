using System;

namespace _1_Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintResult(int.Parse(Console.ReadLine()));
        }
        static void PrintResult(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}
