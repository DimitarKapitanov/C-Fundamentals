using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace _6._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courseAndStudends = new Dictionary<string, List<string>>();
            Dictionary<string, int> courseCount = new Dictionary<string, int>();

            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split(" : ").ToArray();

                if (command[0] == "end")
                {
                    break;
                }

                string courseName = command[0];
                string studentName = command[1];

                if (!courseAndStudends.ContainsKey(courseName))
                {
                    courseAndStudends.Add(courseName, new List<string>());
                    courseCount.Add(courseName, 0);
                }
                courseAndStudends[courseName].Add(studentName);
                courseCount[courseName]++;
            }
            
            foreach (var c in courseCount.OrderByDescending(c => c.Value))
            {
                Console.WriteLine($"{c.Key}: {c.Value}");
                foreach (var s in courseAndStudends)
                {
                    courseAndStudends[s.Key].Sort();
                    if (c.Key == s.Key)
                    {
                        for (int i = 0; i < s.Value.Count; i++)
                        {
                            Console.WriteLine($"-- {s.Value[i]}");
                        }
                    }
                }
            }
        }
    }
}
