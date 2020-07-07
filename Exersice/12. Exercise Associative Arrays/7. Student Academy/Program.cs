using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
            string name = "";
            double grade = 0;
            for (int i = 0; i < n; i++)
            {
                name = Console.ReadLine();
                grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(name))
                {
                    students.Add(name, new List<double>());
                }
                students[name].Add(grade);
            }

            foreach (var item in students.OrderByDescending(x => x.Value.Average()))
            {
                if (item.Value.Average() >= 4.50)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value.Average():F2}");
                }
            }
        }
    }
}
