using System;

namespace _5._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string order = Console.ReadLine();
            double count = double.Parse(Console.ReadLine());

            double result = 0;
            // coffee, coke, water, snacks
            switch (order)
            {
                case "coffee":
                    result = OrderCoffee(count);
                    break;
                case "coke":
                    result = OrderCoke(count);
                    break;
                case "water":
                    result = OrderWater(count);
                    break;
                case "snacks":
                    result = OrderSnacks(count);
                    break;
            }
            Console.WriteLine($"{result:f2}");
        }

        static double OrderCoffee(double count)
        {
            //double coffePrice = 1.5;
            return count * 1.5;
        }

        static double OrderCoke(double count)
        {
            //double coffePrice = 1.4;
            return count * 1.4;
        }
        static double OrderWater(double count)
        {
            //double coffePrice = 1.00;
            return count * 1.00;
        }
        static double OrderSnacks(double count)
        {
            //double coffePrice = 2.00;
            return count * 2.00;
        }

    }
}
