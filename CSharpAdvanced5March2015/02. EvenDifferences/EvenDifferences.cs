namespace _02.EvenDifferences
{
    using System;
    using System.Linq;

    class EvenDifferences
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
