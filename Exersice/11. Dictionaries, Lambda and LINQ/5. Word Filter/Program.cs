using System;
using System.Linq;

namespace _5._Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
                .Split()
                .Where(words => words.Length % 2 == 0)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
