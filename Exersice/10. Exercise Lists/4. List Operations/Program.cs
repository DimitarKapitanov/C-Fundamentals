using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            result = numbers.ToList();

            string command = "";

            while ((command = Console.ReadLine()) != "End")
            {
                string[] splitedCommmand = command.Split().ToArray();

                switch (splitedCommmand[0])
                {
                    case "Add":
                        result.Add(int.Parse(splitedCommmand[1]));
                        break;
                    case "Insert":
                       result = InsertNumbers(result, splitedCommmand);
                        break;
                    case "Remove":
                        result = RemovedNumber(result, splitedCommmand);
                        break;
                    case "Shift":
                        result = Shift(result, splitedCommmand);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }

        private static List<int> Shift(List<int> result, string[] splitedCommmand)
        {
            int shiftTime = int.Parse(splitedCommmand[2]);
            if (splitedCommmand[1] == "left")
            {
                for (int i = 0; i < shiftTime; i++)
                {
                    int temp = result[0];
                    result.Add(temp);
                    result.RemoveAt(0);
                }
            }
            else if (splitedCommmand[1] == "right")
            {
                for (int i = 0; i < shiftTime; i++)
                {
                    int temp = result[result.Count-1];
                    result.Insert(0,temp);
                    result.RemoveAt(result.Count -1);
                }
            }
            return result;
        }

        private static List<int> RemovedNumber(List<int> result, string[] splitedCommmand)
        {
            int index = int.Parse(splitedCommmand[1]);

            if (index >= result.Count || index < 0)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                result.RemoveAt(index);
            }

            return result;
        }

        private static List<int> InsertNumbers(List<int> result, string[] splitedCommmand)
        {
            int index = int.Parse(splitedCommmand[2]);
            int number = int.Parse(splitedCommmand[1]);

            if (index >= result.Count || index < 0)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                result.Insert(index, number);
            }

            return result;
        }
    }
}

