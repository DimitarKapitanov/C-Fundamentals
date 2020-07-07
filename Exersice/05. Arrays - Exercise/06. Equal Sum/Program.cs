using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numb = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numb.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int j = i + 1; j < numb.Length; j++)
                {
                    rightSum += numb[j];
                }

                for (int k = 0; k < i; k++)
                {
                    leftSum += numb[k];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
