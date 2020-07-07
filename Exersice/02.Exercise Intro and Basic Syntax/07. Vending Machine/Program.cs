
using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            double totalMoney = 0;

            while ((command = Console.ReadLine()) != "Start")
            {
                double money = double.Parse(command);

                if (money == 0.1 || money == 0.2 || money == 0.5 || money == 1 || money == 2)
                {
                    totalMoney += money;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {money}");
                }
            }

            double moneyLeft = totalMoney;

            while ((command = Console.ReadLine()) != "End")
            {
                switch (command)
                {
                    case "Nuts":
                        if (moneyLeft - 2.0 < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            moneyLeft -= 2.0;
                            Console.WriteLine($"Purchased nuts");
                        }
                        break;
                    case "Water":
                        if (moneyLeft - 0.7 < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            moneyLeft -= 0.7;
                            Console.WriteLine($"Purchased water");
                        }
                        break;
                    case "Crisps":
                        if (moneyLeft - 1.50 < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            moneyLeft -= 1.50;
                            Console.WriteLine($"Purchased crisps");
                        }
                        break;
                    case "Soda":
                        if (moneyLeft - 0.80 < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            moneyLeft -= 0.80;
                            Console.WriteLine($"Purchased soda");
                        }
                        break;
                    case "Coke":
                        if (moneyLeft - 1.0 < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            moneyLeft -= 1.0;
                            Console.WriteLine($"Purchased coke");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
            }

            Console.WriteLine($"Change: {moneyLeft:f2}");
        }
    }
}
