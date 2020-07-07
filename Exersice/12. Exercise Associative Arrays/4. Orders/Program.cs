using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace _4._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var productsInfo = new Dictionary<string, double>();
            var nameAndPrice = new Dictionary<string, double>();

            string command = "";

            while ((command = Console.ReadLine()) != "buy")
            {
                string[] splitedCommand = command.Split().ToArray();

                string productName = splitedCommand[0];
                double productPrice = double.Parse(splitedCommand[1]);
                int productQuantity = int.Parse(splitedCommand[2]);

                if (!productsInfo.ContainsKey(productName))
                {
                    productsInfo.Add(productName, productQuantity);
                    nameAndPrice.Add(productName, productPrice);
                }
                else
                {
                    productsInfo[productName] += productQuantity;
                    nameAndPrice[productName] = productPrice;
                }
            }

            foreach (var p in productsInfo)
            {
                foreach (var n in nameAndPrice)
                {
                    if (p.Key == n.Key)
                    {
                        Console.WriteLine($"{p.Key} -> {p.Value * n.Value:f2}");
                        break;
                    }
                }
            }
        }
    }
}
