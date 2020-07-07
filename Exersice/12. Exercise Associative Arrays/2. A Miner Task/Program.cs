using System;
using System.Collections.Generic;

namespace _2._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> minerTask = new Dictionary<string, int>();
            string key = "";
            int quantity = 0;

            int count = 0;
            string comand = "";
            while ((comand = Console.ReadLine()) != "stop")
            {

                count++;
                if (count % 2 == 1)
                {
                    key = comand;
                    if (!minerTask.ContainsKey(key))
                    {
                        minerTask.Add(key, 0);
                    }
                }
                else
                {
                    quantity = int.Parse(comand);
                    minerTask[key] += quantity;

                }
            }
            foreach (var item in minerTask)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
