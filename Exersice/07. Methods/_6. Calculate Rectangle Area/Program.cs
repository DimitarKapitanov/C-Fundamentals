using System;

namespace _6._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double result = GetArea(width, height);

            Console.WriteLine(result);
        }

        private static double GetArea(double width, double height)
        {
            return width * height;
        }
    }
}
