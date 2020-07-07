using System;
using System.Linq;

namespace _9._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string values = Console.ReadLine();

            switch (values)
            {
                case "int":
                    GetMaxInt();
                    break;
                case "char":
                    GetMaxChar();
                    break;
                case "string":
                    GetMaxString();
                    break;
            }
        }

        static void GetMaxInt()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine(num1);
            }
            else if (num1 < num2)
            {
                Console.WriteLine(num2);
            }
            else
            {
                Console.WriteLine(num1);
            }
        }

        static void GetMaxChar()
        {
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());
            if (char1 > char2)
            {
                Console.WriteLine(char1);
            }
            else if (char1 < char2)
            {
                Console.WriteLine(char2);
            }
            else
            {
                Console.WriteLine(char1);
            }
        }

        static void GetMaxString()
        {
            string string1 = Console.ReadLine();
            string string2 = Console.ReadLine();

            
            if (string1[0] > string2[0])
            {
                Console.WriteLine(string1);
            }
            else if (string1[0] < string2[0])
            {
                Console.WriteLine(string2);
            }
            else
            {
                Console.WriteLine(string1);
            }
        }
    }
}
