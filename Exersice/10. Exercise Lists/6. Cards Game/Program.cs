using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayer = Console.ReadLine()
                  .Split()
                  .Select(int.Parse)
                  .ToList();

            List<int> secondPlayer = Console.ReadLine()
                   .Split()
                   .Select(int.Parse)
                   .ToList();

            for (int i = 0; i < firstPlayer.Count; i++)
            {
                if (i > firstPlayer.Count - 1 || i > secondPlayer.Count - 1)
                {
                    break;
                }

                else
                {
                    if (firstPlayer[i] > secondPlayer[i])
                    {
                        firstPlayer.Add(firstPlayer[i]);
                        firstPlayer.Add(secondPlayer[i]);
                        firstPlayer.RemoveAt(i);
                        secondPlayer.RemoveAt(i);
                        i--;
                    }

                    else if (secondPlayer[i] > firstPlayer[i])
                    {
                        secondPlayer.Add(secondPlayer[i]);
                        secondPlayer.Add(firstPlayer[i]);
                        secondPlayer.RemoveAt(i);
                        firstPlayer.RemoveAt(i);
                        i--;
                    }

                    else
                    {
                        firstPlayer.RemoveAt(i);
                        secondPlayer.RemoveAt(i);
                        i--;
                    }
                }
            }

            if (firstPlayer.Sum() > secondPlayer.Sum())
            {
                Console.WriteLine($"First player wins! Sum: {firstPlayer.Sum()}");
            }

            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondPlayer.Sum()}");
            }
        }
    }
}
