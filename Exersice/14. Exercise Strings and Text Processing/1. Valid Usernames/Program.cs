using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] readUser = Console.ReadLine()
                .Split(", ")
                .ToArray();

            bool isTrue = false;
            var result = new List<string>();

            foreach (var u in readUser)
            {
                if (u.Length > 2 && u.Length <= 16)
                {
                    for (int i = 0; i < u.Length; i++)
                    {
                        if (char.IsLetterOrDigit(u[i]) || u[i] == '-' || u[i] == '_')
                        {
                            isTrue = true;
                        }
                        else
                        {
                            isTrue = false;
                            break;
                        }
                    }

                    if (isTrue)
                    {
                        result.Add(u);
                    }
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}
