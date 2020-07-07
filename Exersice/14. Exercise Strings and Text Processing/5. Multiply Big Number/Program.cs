using System;
using System.Numerics;

namespace _5._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger firstNumb = BigInteger.Parse(Console.ReadLine());
            int secondNumb = int.Parse(Console.ReadLine());

            Console.WriteLine(firstNumb * secondNumb);
        }
    }
}
