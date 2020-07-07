using System;

namespace _8__Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstInt = double.Parse(Console.ReadLine());
            double secondInt = double.Parse(Console.ReadLine());

            double resut  = PrintFactorialResult(firstInt, secondInt);
            Console.WriteLine($"{resut:f2}");
        }
        static double PrintFactorialResult(double first, double second)
        {
            double firstResult = FirstFactorial(first);
            double secondResult = SecondFactorial(second);

            return firstResult / secondResult;
        }

        private static double FirstFactorial(double first)
        {
            for (double i = first - 1; i >= 1; i--)
            {
                first *= i;
            }
            return first;
        }

        private static double SecondFactorial(double second)
        {
            for (double i = second - 1; i >= 1; i--)
            {
                second *= i;
            }
            return second;
        }
    }
}
