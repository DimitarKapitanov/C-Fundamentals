using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = "";

            while ((command = Console.ReadLine()) != "end")
            {
                string[] splitedCommmand = command.Split().ToArray();

                switch (splitedCommmand[0])
                {
                    case "Delete":
                        numbers = DeleteElement(numbers, splitedCommmand);
                        break;
                    case "Insert":
                        numbers = InsertedElement(numbers, splitedCommmand);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }

        private static List<int> InsertedElement(List<int> numbers, string[] splitedCommmand)
        {
            int element = int.Parse(splitedCommmand[1]);
            int index = int.Parse(splitedCommmand[2]);
            numbers.Insert(index, element);
            return numbers;
        }

        private static List<int> DeleteElement(List<int> numbers, string[] splitedCommmand)
        {
            int element = int.Parse(splitedCommmand[1]);
            numbers.RemoveAll(x => x == element);

            return numbers;
        }
    }
}
