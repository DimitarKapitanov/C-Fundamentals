using System;

namespace _1_Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int result = GetSmalestNumber(a, b, c);
            Console.WriteLine(result);
        }

        static int GetSmalestNumber(int a, int b, int c)
        {
            int result = 0;
            if (a < b && a < c)
            {
                result = a;
            }
            else if (a>b && b<c)
            {
                result = b;
            }
            else
            {
                result = c;
            }
            return result;
        }
    }
}
