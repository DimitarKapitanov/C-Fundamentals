using System;
using System.Linq;
namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagonNumber = int.Parse(Console.ReadLine());
            int[] wagon = new int[wagonNumber];
            int totalPasenger = 0;

            for (int i = 0; i < wagon.Length; i++)
            {
                int pasenger = int.Parse(Console.ReadLine());

                wagon[i] = pasenger;
                totalPasenger += pasenger;
                
            }
            Console.WriteLine(string.Join(" ", wagon));
            Console.WriteLine(totalPasenger);

        }
    }
}
