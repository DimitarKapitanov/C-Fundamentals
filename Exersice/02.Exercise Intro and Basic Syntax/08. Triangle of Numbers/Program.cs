﻿using System;

namespace _8._Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 1; i <= n; i++)
            {
                count = i;
                while (count>0)
                {
                    Console.Write(i+" ");
                    count--;
                }
                Console.WriteLine();
            }
        }
    }
}
