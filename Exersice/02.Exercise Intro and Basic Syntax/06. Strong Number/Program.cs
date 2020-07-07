using System;

namespace _06._Strong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, num;

            num = Convert.ToInt32(Console.ReadLine());

            int currNumber = 0;
            int numb = num;
            int facturialSum = 0;

            while (num != 0)
            {
                currNumber = num % 10;
                num /= 10;
                int f = 1;

                for (i = 1; i <= currNumber; i++)
                {
                    f *= i;
                }

                facturialSum += f;
            }

            if (numb == facturialSum)
            {
                Console.Write("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
