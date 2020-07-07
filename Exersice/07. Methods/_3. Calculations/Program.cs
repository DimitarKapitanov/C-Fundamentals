using System;

namespace _3._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            int firstNumbers = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            switch (comand)
            {
                case "add":
                    Add(firstNumbers, secondNumber);
                    break;
                case "multiply":
                    Multiply(firstNumbers, secondNumber);
                    break;
                case "subtract":
                    Subtract(firstNumbers, secondNumber);
                    break;
                case "divide":
                    Divide(firstNumbers, secondNumber);
                    break;
            }

        }

        static void Add(int firstNumbers, int secondNumber)
        {
            Console.WriteLine(firstNumbers + secondNumber);
        }
        static void Multiply(int firstNumbers, int secondNumber)
        {
            Console.WriteLine(firstNumbers * secondNumber);
        }
        static void Subtract(int firstNumbers, int secondNumber)
        {
            Console.WriteLine(firstNumbers - secondNumber);
        }
        static void Divide(int firstNumbers, int secondNumber)
        {
            Console.WriteLine(firstNumbers / secondNumber);
        }
    }
}
