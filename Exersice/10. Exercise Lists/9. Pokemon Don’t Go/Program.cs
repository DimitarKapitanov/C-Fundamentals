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
                    removedElement = sequence[sequence.Count - 1];
                    result.Add(removedElement);
                    sequence.RemoveAt(sequence.Count - 1);
                    sequence.Add(sequence[0]);
                }
                else if (index < 0)
                {
                    removedElement = sequence[0];
                    result.Add(removedElement);
                    sequence.RemoveAt(0);
                    sequence.Reverse();
                    sequence.Add(sequence[0]);
                    sequence.Reverse();
                }
                else
                {
                    removedElement = sequence[index];
                    result.Add(removedElement);
                    sequence.RemoveAt(index);
                }

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
            Console.WriteLine(result.Sum());
        }
    }
}
