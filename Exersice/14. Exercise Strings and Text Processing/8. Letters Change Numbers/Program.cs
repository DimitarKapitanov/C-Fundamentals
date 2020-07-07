using System;
using System.Linq;

namespace _8._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int letterCount = 0;
            int firstLetterPosition = 0;
            int secondLetterPosition = 0;

            double total = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string currWord = input[i];
                string numbersAsString = "";
                double number = 0;
                double result = 0;

                for (int j = 0; j < currWord.Length; j++)
                {
                    if (char.IsLetter(currWord[j]))
                    {
                        letterCount++;

                        if (letterCount == 1)
                        {
                            if (char.IsUpper(currWord[j]))
                            {
                                firstLetterPosition = currWord[0] - 64;
                            }
                            else if (char.IsLower(currWord[j]))
                            {
                                firstLetterPosition = currWord[0] - 96;
                            }
                        }

                        else
                        {
                            if (char.IsUpper(currWord[j]))
                            {
                                secondLetterPosition = currWord[currWord.Length - 1] - 64;
                            }
                            else if (char.IsLower(currWord[j]))
                            {
                                secondLetterPosition = currWord[currWord.Length - 1] - 96;
                            }
                        }
                    }
                    else if (char.IsDigit(currWord[j]))
                    {
                        numbersAsString += currWord[j];
                    }
                }

                number = double.Parse(numbersAsString);
                result += SumCurrentWord(firstLetterPosition, secondLetterPosition, number, currWord);
                total += result;
                letterCount = 0;
            }
            Console.WriteLine($"{total:F2}");
        }

        private static double SumCurrentWord(int firstLetterPosition, int secondLetterPosition, double number, string currWord)
        {
            double result = 0;

            if (char.IsUpper(currWord[0]))
            {
                result += number / firstLetterPosition;
            }
            if (char.IsLower(currWord[0]))
            {
                result += number * firstLetterPosition;
            }
            if (char.IsUpper(currWord[currWord.Length - 1]))
            {
                result = result - secondLetterPosition;
            }
            if (char.IsLower(currWord[currWord.Length - 1]))
            {
                result = result + secondLetterPosition;
            }
            return result;
        }
    }
}
