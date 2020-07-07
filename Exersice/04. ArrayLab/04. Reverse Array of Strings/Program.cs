using System;
using System.Linq;
namespace _4._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();
            string[] reversedArr = new string[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                reversedArr[i] = arr[arr.Length - i - 1];
            }
                Console.WriteLine(string.Join(" ", reversedArr));
        }
    }
}
