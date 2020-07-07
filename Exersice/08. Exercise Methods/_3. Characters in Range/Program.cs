using System;
using System.Text;

namespace _3._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char startSimbol = char.Parse(Console.ReadLine());
            char endSimbol = char.Parse(Console.ReadLine());

            PrintCharBetween(startSimbol, endSimbol);            
        }
        static void PrintCharBetween(char startSimbol, char endSimbol)
        {
            int asciiStart = Math.Min(startSimbol, endSimbol);
            int asciiEnd = Math.Max(startSimbol, endSimbol);

            for (int asciiCode = asciiStart + 1; asciiCode < asciiEnd; asciiCode++)
            {
                char simbol = (char)asciiCode;
                Console.Write(simbol +" ");
            }
        }
    }
}
