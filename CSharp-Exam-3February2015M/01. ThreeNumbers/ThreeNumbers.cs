using System;

class ThreeNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine(Math.Max(Math.Max(a, b), c));
        Console.WriteLine(Math.Min(Math.Min(a, b), c));
        Console.WriteLine("{0:f2}", (a + b + c) / 3.0);
    }
}

