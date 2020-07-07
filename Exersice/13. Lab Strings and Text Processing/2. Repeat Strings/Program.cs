using System;
using System.Text;

namespace _2._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();

            StringBuilder builder = new StringBuilder();

            int count = 0;
            foreach (var w in arr)
            {
                count = w.Length;
                for (int i = 0; i < count; i++)
                {
                    builder.Append(w);
                }
            }
            Console.WriteLine(builder.ToString());
        }
    }
}
