using System;
using System.Linq;

namespace CSharp_Shell
{

    public static class Program
    {
        public static void Main()
        {
            int feeldSize = int.Parse(Console.ReadLine());
            int[] feeld = new int[feeldSize];

            int[] ladyBugsIndex = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

            for (int i = 0; i < ladyBugsIndex.Length; i++)
            {
                int currIndex = ladyBugsIndex[i];
                if (currIndex >= 0 && currIndex < feeld.Length)
                {
                    feeld[currIndex] = 1;
                }
            }

            string input = "";

            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();

                int startIndex = int.Parse(command[0]);
                int flightLenght = int.Parse(command[2]);
                string direction = command[1];

                if (startIndex < 0 || startIndex > feeld.Length - 1 || feeld[startIndex] == 0)
                {
                    continue;
                }

                feeld[startIndex] = 0;

                if (direction == "right")
                {
                    int landIndex = startIndex + flightLenght;

                    if (landIndex > feeld.Length - 1)
                    {
                        continue;
                    }

                    if (feeld[landIndex] == 1)
                    {
                        while (feeld[landIndex] == 1)
                        {
                            landIndex += flightLenght;

                            if (landIndex > feeld.Length - 1)
                            {
                                break;
                            }
                        }
                    }

                    if (landIndex >= 0 && landIndex <= feeld.Length - 1)
                    {
                        feeld[landIndex] = 1;
                    }
                }

                else if (direction == "left")
                {
                    int landIndex = startIndex - flightLenght;

                    if (landIndex < 0)
                    {
                        continue;
                    }

                    if (feeld[landIndex] == 1)
                    {
                        while (feeld[landIndex] == 1)
                        {
                            landIndex -= flightLenght;

                            if (landIndex < 0)
                            {
                                break;
                            }
                        }
                    }

                    if (landIndex >= 0 && landIndex <= feeld.Length - 1)
                    {
                        feeld[landIndex] = 1;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", feeld));
        }
    }
}