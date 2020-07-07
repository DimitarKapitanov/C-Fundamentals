using System;
using System.Linq;
using System.Collections.Generic;

namespace _4._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbrs = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .OrderByDescending(x => x)
                .Take(3)
                .ToArray();
            Console.WriteLine(string.Join(" ", numbrs));
                
        }
    }
}
