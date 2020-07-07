using System;
using System.Linq;
namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int numberOfRotation = int.Parse(Console.ReadLine());

            //51 47 32 61 21
            //2

            for (int i = 0; i < numberOfRotation - 1 / 2; i++)
            {
                int firstElement = numbers[0];
                int[] temp = new int[numbers.Length];

                for (int j = 0; j < numbers.Length - 1; j++)
                {
                   numbers[j] = numbers[j + 1];
                }
                //temp[temp.Length - 1] = firstElement;
                numbers[numbers.Length - 1] = firstElement;
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
