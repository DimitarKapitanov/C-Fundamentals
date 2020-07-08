using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_1._Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split(" | ")
                .ToList();

            Dictionary<string, List<string>> wordsAndDefinitions = new Dictionary<string, List<string>>();


            for (int i = 0; i < words.Count; i++)
            {
                string[] temp = words[i].Split(": ").ToArray();
                string word = temp[0];
                string definition = temp[1];

                if (!wordsAndDefinitions.ContainsKey(word))
                {
                    wordsAndDefinitions.Add(word, new List<string>());
                    wordsAndDefinitions[word].Add(definition);
                }
                else
                {
                    wordsAndDefinitions[word].Add(definition);
                }
            }

            List<string> secondWord = Console.ReadLine()
                .Split(" | ")
                .ToList();

            foreach (var i in secondWord)
            {
                if (wordsAndDefinitions.ContainsKey(i))
                {
                    Console.WriteLine($"{i}");

                    foreach (var word in wordsAndDefinitions)
                    {
                        foreach (var dis in word.Value.OrderByDescending(x => x.Length))
                        {
                            if (i == word.Key)
                            {
                                Console.WriteLine($" -{dis}");
                            }
                        }
                    }
                }
            }

            string command = Console.ReadLine();

            if (command.StartsWith("List"))
            {
                foreach (var word in wordsAndDefinitions.OrderBy(x => x.Key))
                {
                    Console.Write($"{word.Key} ");
                }
            }
        }
    }
}
