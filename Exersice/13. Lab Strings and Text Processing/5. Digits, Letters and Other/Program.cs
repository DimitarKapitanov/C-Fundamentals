using System;
using System.Text;

namespace _5._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var numb = new StringBuilder();
            var leter = new StringBuilder();
            var other = new StringBuilder();


            foreach (var i in input)
            {
                if (char.IsDigit(i))
                {
                    numb.Append(i);
                }
                else if (char.IsLetter(i))
                {
                    leter.Append(i);
                }
                else
                {
                    other.Append(i);
                }
            }
            Console.WriteLine(numb.ToString());
            Console.WriteLine(leter.ToString());
            Console.WriteLine(other.ToString());
        }
    }
}
