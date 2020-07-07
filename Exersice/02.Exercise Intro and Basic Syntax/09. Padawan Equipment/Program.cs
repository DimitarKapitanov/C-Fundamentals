using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int student = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            double lightsabersSum = Math.Ceiling(student * 1.1) * lightsabersPrice;
            double robesSum = student * robesPrice;
            double beltsSum = (student - (student / 6)) * beltsPrice;

            double totalPrice = lightsabersSum + robesSum + beltsSum;

            if (money >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {Math.Abs(totalPrice - money):f2}lv more.");
            }
        }
    }
}
