using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string patern = @"[>>]{2}(?<product>\w+)[<<]{2}(?<price>\d+\.?\d+)[!](?<count>\d+)";

            Regex match = new Regex(patern);

            double sum = 0.0;
            int quantity = 0;
            List<string> product = new List<string>();
            double totalSum = 0.0;

            string text = "";

            while ((text = Console.ReadLine()) != "Purchase")
            {
                MatchCollection matchetText = Regex.Matches(text, patern);

                foreach (Match t in matchetText)
                {
                    product.Add(t.Groups["product"].Value);
                    sum = double.Parse(t.Groups["price"].Value);
                    quantity = int.Parse(t.Groups["count"].Value);
                }
                if (matchetText.Count > 0)
                {
                    sum *= quantity;
                    totalSum += sum;
                }
            }

            Console.WriteLine("Bought furniture:");
            foreach (var item in product)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {totalSum:f2}");
        }
    }
}
