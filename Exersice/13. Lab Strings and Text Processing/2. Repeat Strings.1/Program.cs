using System;
using System.Collections.Generic;
using System.Text;

namespace _2._Repeat_Strings._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();

            string builder = "";

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    builder += arr[i];
                }
            }
            Console.WriteLine(builder);
        }
    }
}
