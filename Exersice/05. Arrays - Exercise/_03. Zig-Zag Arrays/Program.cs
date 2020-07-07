using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int line = int.Parse(Console.ReadLine());

            int[] firstArr = new int[line];
            int[] secondArr = new int[line];

            for (int i = 0; i < line; i++)
            {
                int[] number = Console.ReadLine().Split().Select(int.Parse).ToArray();
                
                if (i % 2 == 0)
                {
                    firstArr[i] = number[0];
                    secondArr[i] = number[1];
                }
                else if (i % 2 == 1)
                {
                    firstArr[i] = number[1];
                    secondArr[i] = number[0];
                }
            }
            Console.WriteLine(string.Join(" ", firstArr));            
            Console.WriteLine(string.Join(" ", secondArr));
        }
    }
}
