using System;

class Cube
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(new string(' ', n - 1) + new string(':', n)); // print the first line
        for (int i = 0; i < n - 2; i++)
        {
            Console.WriteLine(new string(' ', (n - 2 - i)) + ":" +
                new string('/', n - 2) + ":" + new string('X', i) + ":");
        }
        Console.WriteLine(new string(':', n) + new string('X', n - 2) + ":");
        for (int j = n - 2; j > 0; j--)
        {
            Console.WriteLine(":" + new string(' ', n - 2) + ":" + new string('X', j - 1) + ":");
        }
        Console.WriteLine(new string(':', n));
    }
}

