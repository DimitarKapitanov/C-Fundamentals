using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> coursePlanning = Console.ReadLine().Split(", ").ToList();

            string command = "";
            while ((command = Console.ReadLine()) != "course start")
            {
                string[] splitedComand = command.Split(":").ToArray();

                switch (splitedComand[0])
                {
                    case "Add":
                        Add(splitedComand[1], coursePlanning);
                        break;
                    case "Insert":
                        Insert(coursePlanning, splitedComand);
                        break;
                    case "Remove":
                        Remove(coursePlanning, splitedComand);
                        break;
                    case "Swap":
                        Swap(coursePlanning, splitedComand);
                        break;
                    case "Exercise":
                        Exercise(coursePlanning, splitedComand);
                        break;
                }
            }
            for (int i = 0; i < coursePlanning.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{coursePlanning[i]}");
            }
        }

        private static void Exercise(List<string> coursePlanning, string[] splitedComand)
        {
            string lessonTitle = splitedComand[1];
            bool isFind = false;
            int index = 0;
            for (int i = 0; i < coursePlanning.Count; i++)
            {
                if (lessonTitle == coursePlanning[i])
                {
                    index = i;
                    isFind = true;
                    break;
                }
            }
            if (isFind)
            {
                if (!coursePlanning.Contains(lessonTitle + "-Exercise"))
                {
                    coursePlanning.Insert(index + 1, lessonTitle + "-Exercise");
                }
            }
            else
            {
                coursePlanning.Add(lessonTitle);
                coursePlanning.Add(lessonTitle + "-Exercise");
            }
        }
        private static void Swap(List<string> coursePlanning, string[] splitedComand)
        {
            if (coursePlanning.Contains(splitedComand[1]) && coursePlanning.Contains(splitedComand[2]))
            {
                string firstLesson = splitedComand[1];
                string secondLesson = splitedComand[2];

                for (int i = 0; i < coursePlanning.Count; i++)
                {
                    if (firstLesson == coursePlanning[i])
                    {
                        FirstLesonFound(coursePlanning, secondLesson, i);
                    }
                    else if (secondLesson == coursePlanning[i])
                    {
                        SecondLesonFound(coursePlanning, firstLesson, i);
                    }
                }
            }
        }
        private static void FirstLesonFound(List<string> coursePlanning, string secondLesson, int i)
        {
            coursePlanning[i] = secondLesson;
            int temp = coursePlanning.IndexOf(secondLesson + "-Exercise");

            if (coursePlanning.Contains(secondLesson + "-Exercise"))
            {
                coursePlanning.RemoveAt(temp);
                if (i + 1 > coursePlanning.Count)
                {
                    coursePlanning.Add(secondLesson + "-Exercise");
                }
                else
                {
                    coursePlanning.Insert(i + 1, secondLesson + "-Exercise");
                }
            }
        }
        private static void SecondLesonFound(List<string> coursePlanning, string firstLesson, int i)
        {
            coursePlanning[i] = firstLesson;
            int temp = coursePlanning.IndexOf(firstLesson + "-Exercise");
            if (coursePlanning.Contains(firstLesson + "-Exercise"))
            {
                coursePlanning.RemoveAt(temp);
                if (i + 1 > coursePlanning.Count)
                {
                    coursePlanning.Add(firstLesson + "-Exercise");
                }
                else
                {
                    coursePlanning.Insert(i + 1, firstLesson + "-Exercise");
                }
            }
        }

        private static void Remove(List<string> coursePlanning, string[] splitedComand)
        {
            if (coursePlanning.Contains(splitedComand[1]))
            {
                coursePlanning.Remove(splitedComand[1]);
                if (coursePlanning.Contains(splitedComand[1] + "-Exercise"))
                {
                    coursePlanning.Remove(splitedComand[1] + "-Exercise");
                }
            }
        }

        private static void Insert(List<string> coursePlanning, string[] splitedComand)
        {
            if (!coursePlanning.Contains(splitedComand[1]))
            {
                if (int.Parse(splitedComand[2]) < coursePlanning.Count && int.Parse(splitedComand[2]) >= 0)
                {
                    coursePlanning.Insert(int.Parse(splitedComand[2]), splitedComand[1]);
                }
            }
        }

        private static void Add(string v, List<string> coursePlanning)
        {
            if (!coursePlanning.Contains(v))
            {
                coursePlanning.Add(v);
            }
        }
    }
}