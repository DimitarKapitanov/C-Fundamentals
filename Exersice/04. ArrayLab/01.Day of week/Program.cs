using System;

namespace ArrayLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            string[] dayOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            if (day >= 1 && day <= 7)
            {
                Console.WriteLine(dayOfWeek[day-1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
