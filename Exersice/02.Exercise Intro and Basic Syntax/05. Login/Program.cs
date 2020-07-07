using System;
using System.Linq;
using System.Text;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string reversedInput = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversedInput += input[i];
            }

            string password = "";
            int count = 0;

            while ((password = Console.ReadLine()) != reversedInput)
            {
                count++;

                if (count == 4)
                {
                    Console.WriteLine($"User {input} blocked!");
                    break;
                }

                Console.WriteLine("Incorrect password. Try again.");
            }

            if (reversedInput == password)
            {
                Console.WriteLine($"User {input} logged in.");
            }
        }
    }
}
