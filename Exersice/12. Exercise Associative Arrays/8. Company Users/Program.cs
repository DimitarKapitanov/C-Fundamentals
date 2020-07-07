using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace _8._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyAndEmployee = new Dictionary<string, List<string>>();


            while (true)
            {
                string[] command = Console.ReadLine().Split(" -> ").ToArray();
                if (command[0] == "End")
                {
                    break;
                }

                string companyName = command[0];
                string employeeId = command[1];

                if (!companyAndEmployee.ContainsKey(companyName))
                {
                    companyAndEmployee.Add(companyName, new List<string>());
                    companyAndEmployee[companyName].Add(employeeId);
                }
                if (!companyAndEmployee[companyName].Contains(employeeId))
                {
                    companyAndEmployee[companyName].Add(employeeId);
                }
            }

            foreach (var c in companyAndEmployee.OrderBy(c => c.Key))
            {
                Console.WriteLine(c.Key);
                for (int i = 0; i < c.Value.Count; i++)
                {
                    Console.WriteLine($"-- {c.Value[i]}");
                }
            }
        }
    }
}
