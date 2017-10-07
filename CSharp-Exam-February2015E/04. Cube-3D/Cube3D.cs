using System;

class Cube3D
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(new string(':', n));
        for (int i = 0; i < n - 2; i++)
        {
            Console.WriteLine(":" + new string(' ', n - 2) + ":" + new string('|', i) + ":");
        }
        Console.WriteLine(new string(':', n) + new string('|', n - 2) + ":");
        for (int j = 0; j < n - 2; j++)
        {
            Console.WriteLine(new string(' ', j + 1) + ":" +
                new string('-', n - 2) + ":" + new string('|', n - 3 - j) + ":");
        }
        Console.WriteLine(new string(' ', n - 1) + new string(':', n));
    }
}

