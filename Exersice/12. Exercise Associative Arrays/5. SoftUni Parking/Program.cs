using System;
using System.Collections.Generic;

namespace _5._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfComands = int.Parse(Console.ReadLine());

            Dictionary<string, string> customer = new Dictionary<string, string>();

            for (int i = 0; i < numberOfComands; i++)
            {
                string[] command = Console.ReadLine().Split();

                string username = command[1];

                if (command.Length > 2)
                {
                    string licensePlateNumber = command[2];
                    if (!customer.ContainsKey(username))
                    {
                        customer.Add(username, licensePlateNumber);
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }
                }
                else
                {
                    if (!customer.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        customer.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }

            foreach (var c in customer)
            {
                Console.WriteLine($"{c.Key} => {c.Value}");
            }
        }
    }
}
