using System;
using System.Collections.Generic;
using System.Linq;

namespace _9._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            while (sequence.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                int removedElement = 0;

                if (index > sequence.Count - 1)
                {
                    result.Add(BigerIndex(sequence, index));
                }
                else if (index < 0)
                {
                    result.Add(LolwerIndex(sequence, index));
                }
                else
                {
                    result.Add(IndexInRange(sequence, index));
                }
            }
            Console.WriteLine(result.Sum());
        }

        private static void SequenceConvert(List<int> sequence, int removedElement)
        {
            for (int i = 0; i < sequence.Count; i++)
            {
                if (sequence[i] <= removedElement)
                {
                    sequence[i] += removedElement;
                }
                else
                {
                    sequence[i] -= removedElement;
                }
            }
        }

        private static int IndexInRange(List<int> sequence, int index)
        {
            int removedElement = sequence[index];
            sequence.RemoveAt(index);
            SequenceConvert(sequence, removedElement);
            return removedElement;
        }

        static int BigerIndex(List<int> sequence, int index)
        {
            int removedElement = sequence[sequence.Count - 1];
            sequence[sequence.Count - 1] = sequence[0];
            SequenceConvert(sequence, removedElement);
            return removedElement;
        }
        static int LolwerIndex(List<int> sequence, int index)
        {
            int removedElement = sequence[0];
            sequence[0] = sequence[sequence.Count - 1];
            SequenceConvert(sequence, removedElement);
            return removedElement;
        }
    }
}
