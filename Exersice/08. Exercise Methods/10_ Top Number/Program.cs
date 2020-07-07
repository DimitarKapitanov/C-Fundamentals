using System;

namespace TopNumber
{
    class TopNumber
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i < number; i++)
            {
                if (IsTopNummb(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsTopNummb(int number)
        {
            bool isTopNummb = false;
            bool isTopDigit = false;

            int temp = number;
            int sum = 0;
            
            while (temp > 0)
            {
                int digit = temp % 10;
                sum += digit;
                temp /= 10;

                if (digit % 2 != 0)
                {
                    isTopDigit = true;
                }
            }

            if (sum % 8 == 0)
            {
                isTopNummb = true;
            }
            return isTopNummb && isTopDigit;
        }
    }
}
