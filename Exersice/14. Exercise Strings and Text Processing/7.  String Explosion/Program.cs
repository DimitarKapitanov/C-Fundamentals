using System;
using System.Linq;
using System.Text;

namespace _7.__String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int bombCount = 0;
            int indexOfExp = 0;
            int currBombStr = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    indexOfExp = i;
                    currBombStr = int.Parse(input[i + 1].ToString());
                    input = input.Remove(indexOfExp + 1, 1);

                    if (currBombStr > 1)
                    {
                        currBombStr--;
                        bombCount += currBombStr;
                    }

                }
                else if (char.IsLetter(input[i]) && bombCount > 0)
                {
                    input = input.Remove(indexOfExp + 1, 1);
                    bombCount--;
                    i--;
                }
            }
            Console.WriteLine(input);
        }
    }
}
