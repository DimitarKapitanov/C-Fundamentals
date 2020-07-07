using System;
using System.Collections.Generic;
using System.Linq;

namespace _9._ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> forceSideAndUser = new Dictionary<string, List<string>>();

            string forceSide = "";
            string forceUser = "";

            while (true)
            {
                string command = Console.ReadLine();

                string[] splitedComand = null;

                if (command == "Lumpawaroo")
                {
                    break;
                }

                if (command.Contains("|"))
                {
                    splitedComand = command
                        .Split(" | ")
                        .ToArray();

                    AddForceSideOrUser(splitedComand, forceSideAndUser);
                }
                else if (command.Contains("->"))
                {
                    splitedComand = command
                        .Split(" -> ")
                        .ToArray();

                    RemoveAndAddForceSideOrUser(splitedComand, forceSideAndUser);
                }
            }

            foreach (var side in forceSideAndUser.Where(x => x.Value.Count > 0).OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");

                foreach (var user in side.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"! {user}");
                }
            }
        }

        private static void RemoveAndAddForceSideOrUser(string[] command, Dictionary<string, List<string>> forceSideAndUser)
        {
            string forceSide = command[1];
            string forceUser = command[0];

            foreach (var u in forceSideAndUser)
            {
                if (forceSideAndUser[u.Key].Contains(forceUser) && !u.Key.Contains(forceSide))
                {
                    forceSideAndUser.Remove(u.Key);
                    break;
                }
            }

            if (!forceSideAndUser.ContainsKey(forceSide))
            {
                forceSideAndUser.Add(forceSide, new List<string>());
            }

            forceSideAndUser[forceSide].Add(forceUser);

            PritJoinSide(forceSide, forceUser);
        }

        private static void PritJoinSide(string forceSide, string forceUser)
        {
            Console.WriteLine($"{forceUser} joins the {forceSide} side!");
        }

        private static void AddForceSideOrUser(string[] command, Dictionary<string, List<string>> forceSideAndUser)
        {
            string forceSide = command[0];
            string forceUser = command[1];

            if (!forceSideAndUser.ContainsKey(forceSide))
            {
                forceSideAndUser.Add(forceSide, new List<string>());
            }

            foreach (var side in forceSideAndUser)
            {
                if (forceSideAndUser[side.Key].Contains(forceUser))
                {
                    return;
                }
            }

            forceSideAndUser[forceSide].Add(forceUser);
        }
    }
}
