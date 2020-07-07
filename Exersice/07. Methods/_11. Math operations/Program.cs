using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            string inputOperator = Console.ReadLine();
            double num2 = double.Parse(Console.ReadLine());

            double result = GetResult(num1, inputOperator, num2);
            Console.WriteLine($"{result}");
        }

        static double GetResult(double num1, string inputOperator, double num2)
        {
            double result = 0;

            switch (inputOperator)
            {
                case "/":
                    result = (num1 / num2);
                    break;
                case "*":
                    result = (num1 * num2);
                    break;
                case "+":
                    result = (num1 + num2);
                    break;
                case "-":
                    result = (num1 - num2);
                    break;
            }
            return result;
        }
    }
}
