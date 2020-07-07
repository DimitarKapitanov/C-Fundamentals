using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split()
                .ToList();

            
            string comand = "";

            while ((comand = Console.ReadLine()) != "3:1")
            {
                string[] splitedComand = comand.Split().ToArray();
                
                switch (splitedComand[0])
                {   
                    case "merge":
                        Marge(input, splitedComand);
                        break;
                    case "divide":
                        Divided(input, splitedComand);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }


        private static void Marge(List<string> input, string[] splitedComand)
        {
            int startIndex = int.Parse(splitedComand[1]);
            int endIndex = int.Parse(splitedComand[2]);

            if (startIndex <0)
            {
                startIndex = 0;
            }

            if (endIndex > input.Count - 1)
            {
                endIndex = input.Count - 1;
            }

            for (int i = startIndex; i < endIndex; i++)
            {
                input[startIndex] += input[startIndex + 1];
                input.RemoveAt(startIndex + 1);
            }
        }
        private static void Divided(List<string> input, string[] splitedComand)
        {
            int startIndex = int.Parse(splitedComand[1]);
            int partitions = int.Parse(splitedComand[2]);

            List<string> newCollection = new List<string>();

            string temp = input[startIndex];

            input.RemoveAt(startIndex);

            int parts = temp.Length / partitions;

            for (int i = 0; i < partitions; i++)
            {
                if (i == partitions - 1)
                {
                    newCollection.Add(temp.Substring(i * parts));
                }
                else
                {
                    newCollection.Add(temp.Substring(i * parts, parts));
                }
            }
            input.InsertRange(startIndex, newCollection);
        }
    }
}
