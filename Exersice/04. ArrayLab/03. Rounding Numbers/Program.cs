    using System;
    using System.Linq;

    namespace _03._Rounding_Numbers
    {
        class Program
        {
            static void Main(string[] args)
            {
                double[] number = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            
                for (int i = 0; i < number.Length; i++)
                {
                   int roubndetNumber = (int)Math.Round(number[i], 0, MidpointRounding.AwayFromZero);
                   Console.WriteLine($"{number[i]} => {roubndetNumber}");
                }
            }
        }
    }
