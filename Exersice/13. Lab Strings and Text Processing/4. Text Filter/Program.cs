using System;
using System.Linq;
using System.Text;

namespace _4._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ban = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            foreach (var b in ban)
            {

                if (text.Contains(b))
                {
                    text = text.Replace(b, new string('*', b.Length));                    
                }
            }

            Console.WriteLine(text);
        }
    }
}
