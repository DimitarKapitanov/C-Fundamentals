using System;
using System.Linq;
namespace _09.__Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            // longest subsequence of one
            // leftmost start index
            // greater sum

            int number = int.Parse(Console.ReadLine());

            string line = "";
            
            int[] bestDna = new int[number];

            int currSimple = 0;

            int maxCount = 0;
            int maxIndex = 0;
            int maxSum = 0;
            int bestSimple = 1;

            while ((line = Console.ReadLine()) != "Clone them!")
            {
                int[] arr = line
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                currSimple++;
                int currCount = 1;
                int bestIndex = 0;
                int bestCount = 0;
                int currSum = 0;

                for (int currIndex = 0; currIndex < arr.Length; currIndex++)
                {
                    if (arr[currIndex] == 0)
                    {
                        continue;
                    }

                    for (int j = currIndex + 1; j < arr.Length; j++)
                    {
                        if (arr[j] == 1)
                        {
                            currCount++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (currCount > bestCount)
                    {
                        bestCount = currCount;
                        bestIndex = currIndex;
                        currSum = arr.Sum();
                    }
                }

                if (bestCount > maxCount ||
                    (bestCount == maxCount && maxIndex > bestIndex) ||
                    currSum > maxSum)
                {
                    maxCount = bestCount;
                    maxIndex = bestIndex;
                    maxSum = currSum;
                    bestDna = arr.ToArray();
                    bestSimple = currSimple;
                }
            }
            Console.WriteLine($"Best DNA sample {bestSimple} with sum: {maxSum}.");
            Console.WriteLine(string.Join(" ", bestDna));
        }
    }
}
