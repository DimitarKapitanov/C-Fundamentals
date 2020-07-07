using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _10._SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> students = new Dictionary<string, int>();
            Dictionary<string, int> language = new Dictionary<string, int>();

            string command = "";

            while (true)
            {
                command = Console.ReadLine();

                if (command == "exam finished")
                {
                    break;
                }

                string[] splited = command.Split("-").ToArray();

                if (splited.Length > 2)
                {

                    string student = splited[0];
                    int points = int.Parse(splited[2]);
                    string course = splited[1];

                    if (!students.ContainsKey(splited[0]))
                    {
                        students.Add(student, 0);
                        if (!language.ContainsKey(course))
                        {
                            language.Add(course, 0);
                        }
                    }
                    if (students[student] <= points)
                    {
                        students[student] = points;
                    }
                    
                    language[course]++;
                }

                else
                {
                    string student = splited[0];
                    string banned = splited[1];

                    if (students.ContainsKey(splited[0]))
                    {
                        students.Remove(student);
                    }
                }
            }
            Console.WriteLine("Results:");
            foreach (var stud in students.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{stud.Key} | {stud.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var c in language.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{c.Key} - {c.Value}");
            }
        }
    }
}
