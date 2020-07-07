using System;
using System.Linq;

namespace _9__Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";

            while ((input = Console.ReadLine()) != "END")
            {
                IsPalindrome(input);
                if (IsPalindrome(input))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
        static bool IsPalindrome(string input)
        {
            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] == input[input.Length - 1 - i])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
