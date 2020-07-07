using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                .Split(", ")
                .ToList();

            Dictionary<string, int> result = new Dictionary<string, int>();

            string input = "";

            while ((input = Console.ReadLine()) != "end of race")
            {
                
            }
        }
    }
}
