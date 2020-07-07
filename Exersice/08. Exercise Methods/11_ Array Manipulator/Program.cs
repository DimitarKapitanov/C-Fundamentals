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
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string comand = "";

            while ((comand = Console.ReadLine()) != "end")
            {
                string[] splitedComand = comand.Split().ToArray();

                switch (splitedComand[0])
                {
                    case "exchange":
                        int index = int.Parse(splitedComand[1]);
                        Exchange(index, numbers);
                        break;
                    case "max":
                        MaxEvenAndOdd(splitedComand, numbers);
                        break;
                    case "min":
                        MinEvenAndOdd(numbers, splitedComand);
                        break;
                    case "first":
                        int count = int.Parse(splitedComand[1]);
                        FirstEvenOrOdd(splitedComand, numbers, count);
                        break;
                    case "last":
                        count = int.Parse(splitedComand[1]);
                        LastEvenOrOdd(splitedComand, numbers, count);
                        break;
                }
            }
            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }

        private static void Exchange(int index, List<int> numbers)
        {

            if (index >= 0 && index < numbers.Count)
            {
                List<int> temp = new List<int>();
                for (int i = 0; i <= index; i++)
                {
                    temp.Add(numbers[i]);
                }
                numbers.RemoveRange(0, index + 1);
                numbers.AddRange(temp);
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
        }
        private static void MaxEvenAndOdd(string[] splitedComand, List<int> numbers)
        {
            int maxEvenOrOddElement = int.MinValue;
            int maxEvenOrOddIndex = -1;

            if (splitedComand[1] == "even")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 0 && numbers[i] >= maxEvenOrOddElement)
                    {
                        maxEvenOrOddElement = numbers[i];
                        maxEvenOrOddIndex = i;
                    }
                }
            }
            else if (splitedComand[1] == "odd")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 != 0 && numbers[i] >= maxEvenOrOddElement)
                    {
                        maxEvenOrOddElement = numbers[i];
                        maxEvenOrOddIndex = i;
                    }
                }
            }
            if (maxEvenOrOddIndex == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(maxEvenOrOddIndex);
            }
        }
        private static void MinEvenAndOdd(List<int> numbers, string[] splitedComand)
        {
            int minEvenOrOddElement = int.MaxValue;
            int minEvenOrOddIndex = -1;

            if (splitedComand[1] == "even")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 0 && numbers[i] <= minEvenOrOddElement)
                    {
                        minEvenOrOddElement = numbers[i];
                        minEvenOrOddIndex = i;
                    }
                }
            }
            else if (splitedComand[1] == "odd")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 != 0 && numbers[i] <= minEvenOrOddElement)
                    {
                        minEvenOrOddElement = numbers[i];
                        minEvenOrOddIndex = i;
                    }
                }
            }
            if (minEvenOrOddIndex == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(minEvenOrOddIndex);
            }
        }
        private static void LastEvenOrOdd(string[] splitedComand, List<int> numbers, int count)
        {
            int counter = 0;
            List<int> list = new List<int>();

            if (splitedComand[2] == "even")
            {
                if (count > numbers.Count || count < 0)
                {
                    Console.WriteLine("Invalid count");
                }
                else
                {
                    for (int i = numbers.Count - 1; i >= 0; i--)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            counter++;
                            if (counter <= count)
                            {
                                list.Add(numbers[i]);
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    if (counter == 0)
                    {
                        Console.WriteLine($"[]");
                    }
                    else
                    {
                        list.Reverse();
                        Console.WriteLine($"[{string.Join(", ", list)}]");
                    }
                }
            }

            else if (splitedComand[2] == "odd")
            {
                if (count > numbers.Count || count < 0)
                {
                    Console.WriteLine("Invalid count");
                }
                else
                {
                    for (int i = numbers.Count - 1; i >= 0; i--)
                    {
                        if (numbers[i] % 2 != 0)
                        {
                            counter++;
                            if (counter <= count)
                            {
                                list.Add(numbers[i]);
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    if (counter == 0)
                    {
                        Console.WriteLine($"[]");
                    }
                    else
                    {
                        list.Reverse();
                        Console.WriteLine($"[{string.Join(", ", list)}]");
                    }
                }
            }
        }
        private static void FirstEvenOrOdd(string[] splitedComand, List<int> numbers, int count)
        {
            int counter = 0;
            List<int> list = new List<int>();

            if (splitedComand[2] == "even")
            {
                if (count > numbers.Count || count < 0)
                {
                    Console.WriteLine("Invalid count");
                }
                else
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            counter++;
                            if (counter <= count)
                            {
                                list.Add(numbers[i]);
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    if (counter == 0)
                    {
                        Console.WriteLine($"[]");
                    }
                    else
                    {
                        Console.WriteLine($"[{string.Join(", ", list)}]");
                    }
                }
            }

            else if (splitedComand[2] == "odd")
            {
                if (count > numbers.Count || count < 0)
                {
                    Console.WriteLine("Invalid count");
                }
                else
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 != 0)
                        {
                            counter++;
                            if (counter <= count)
                            {
                                list.Add(numbers[i]);
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    if (counter == 0)
                    {
                        Console.WriteLine($"[]");
                    }
                    else
                    {
                        Console.WriteLine($"[{string.Join(", ", list)}]");
                    }
                }
            }
        }

    }
}

