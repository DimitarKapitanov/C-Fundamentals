using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace _11__Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string comand = "";
            while ((comand = Console.ReadLine()) != "end")
            {
                //switch (switch_on)
                //{
                //    default:
                //}
                Exchange(comand, numbers);
            }
        }

        private static void Exchange(string comand, int[] numbers)
        {
            string[] splitedComand = comand.Split().ToArray();
            int index = int.Parse(splitedComand[1]);

            int temp = 0;

            for (int j = 0; j <= index; j++)
            {
                temp = numbers[j];
                numbers[j] = numbers[numbers.Length - 1];
                numbers[numbers.Length - 1] = temp;
            }
            Console.WriteLine(string.Join(",", numbers));

        }
    }
}