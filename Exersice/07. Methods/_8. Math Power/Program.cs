using System;

namespace _8._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            double result = RiseToPower(num1, num2);
            Console.WriteLine(result);
        }

        static double RiseToPower(double num1, double num2)
        {
            double power = 1;
            for (int i = 0; i < num2; i++)
            {
                power = power * num1;
            }
            return power;
        }
    }
}
