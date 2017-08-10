using System;

namespace _02.GetLargestNumber
{
    class GetLargestNumber
    {
        static void Main()
        {
            string[] numbers = Console.ReadLine().Split(' ');
            int a = int.Parse(numbers[0]);
            int b = int.Parse(numbers[1]);
            int c = int.Parse(numbers[2]);
            Console.WriteLine(GetMax(GetMax(a, b), GetMax(b, c)));
        }

        public static int GetMax(int a, int b)
        {
            int larger = a > b ? a : b;
            return larger;
        }
    }
}
