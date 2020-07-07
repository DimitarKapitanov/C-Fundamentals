using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int wagonsMaxCapacity = int.Parse(Console.ReadLine());

            string command = "";
            while ((command = Console.ReadLine()) != "end")
            {
                string[] splitedCommmand = command.Split().ToArray();
                if (splitedCommmand[0] == "Add")
                {
                    int passengers = int.Parse(splitedCommmand[1]);
                    wagons.Add(passengers);
                }
                else
                {
                    int passengers = int.Parse(command);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passengers <= wagonsMaxCapacity)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }

            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
