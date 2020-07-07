using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int maxSequence = 0;
            int lenght = 1;

            int start = 0;
            int beststart = 0;

            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] == array[i+1])
                {
                    lenght++;
                }
                else
                {
                    lenght = 1;
                    start = i + 1;
                }

                if (lenght > maxSequence)
                {
                    maxSequence = lenght;
                    beststart = start;
                }
            }

            for (int i = beststart; i < beststart + maxSequence; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
