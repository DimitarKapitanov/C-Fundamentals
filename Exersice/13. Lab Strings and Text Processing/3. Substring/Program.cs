using System;
using System.Linq;
using System.Text;

namespace _3._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine().ToLower();
            string second = Console.ReadLine().ToLower();

            for (int i = 0; i < second.Length; i++)
            {
                int index = second.IndexOf(first);
                if (index < 0)
                {
                    continue;
                }
                second = second.Remove(index, first.Length);
            }
            Console.WriteLine(second);
        }
    }
}
