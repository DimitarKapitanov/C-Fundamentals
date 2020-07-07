using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int comandCount = int.Parse(Console.ReadLine());

            List<string> guest = new List<string>();

            for (int i = 0; i < comandCount; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();
                
                switch (command[2])
                {
                    case "going!":
                        guest = GoingCheck(command[0], guest);
                        break;
                    case "not":
                        guest = NotGoingCheck(command[0], guest);
                        break;
                }
            }

            foreach (var item in guest)
            {
                Console.WriteLine(item);
            }
        }

        private static List<string> NotGoingCheck(string v, List<string> guest)
        {
            if (guest.Contains(v))
            {
                guest.Remove(v);
            }
            else
            {
                Console.WriteLine($"{v} is not in the list!");
            }

            return guest;
        }

        private static List<string> GoingCheck(string v, List<string> guest)
        {
            if (guest.Contains(v))
            {
                Console.WriteLine($"{v} is already in the list!");
            }
            else
            {
                guest.Add(v);
            }

            return guest;
        }
    }
}
