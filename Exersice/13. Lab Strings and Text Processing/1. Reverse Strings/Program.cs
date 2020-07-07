using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = "";


            while ((comand = Console.ReadLine()) != "end")
            {
                string reversed = "";
                for (int i = comand.Length - 1; i >= 0; i--)
                {
                    reversed += comand[i];
                }
                Console.WriteLine($"{comand} = {reversed}");
            }
        }
    }
}
