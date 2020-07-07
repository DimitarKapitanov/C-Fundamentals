using System;
using System.Linq;

namespace _3.__Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] directory = Console.ReadLine().Split("\\").ToArray();

            string[] arr = directory[directory.Length - 1].Split(".").ToArray();

            Console.WriteLine($"File name: {arr[0]}");
            Console.WriteLine($"File extension: {arr[1]}");
        }
    }
}
