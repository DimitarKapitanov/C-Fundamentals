using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string someString = Console.ReadLine();
            List<char> toChar = new List<char>();
            for (int i = 0; i < someString.Length; i++)
            {
                if (someString[i] != ' ')
                {
                    toChar.Add(someString[i]);
                }
            }

            var count = new Dictionary<char, int>();

            foreach (var item in toChar)
            {
                if (count.ContainsKey(item) == false)
                {
                    count.Add(item, 0);
                }
                count[item]++;
            }

            foreach (var item in count)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
