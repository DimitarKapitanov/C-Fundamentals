using System;

namespace _2_Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int result = CountOfVowels(input);
            Console.WriteLine(result);
        }

        static int CountOfVowels(string input)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'A' || input[i] == 'a')
                {
                    count++;
                }
                else if (input[i] == 'E' || input[i] == 'e')
                {
                    count++;
                }
                else if (input[i] == 'I' || input[i] == 'i')
                {
                    count++;
                }
                else if (input[i] == 'O' || input[i] == 'o')
                {
                    count++;
                }
                else if (input[i] == 'U' || input[i] == 'u')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
