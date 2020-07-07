using System;

namespace _5__Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInt = int.Parse(Console.ReadLine());
            int secondInt = int.Parse(Console.ReadLine());
            int thirdInt = int.Parse(Console.ReadLine());

            int result = SumAndSubstractInteger(firstInt, secondInt, thirdInt);
            Console.WriteLine(result);
        }
        static int SumAndSubstractInteger(int first, int second, int third)
        {
            return first + second - third;
        }
    }
}
