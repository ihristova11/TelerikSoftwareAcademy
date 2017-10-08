using System;

class PersianRugs
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        if (d > 2 * n - 3)
        {
            d = 0;
        }
    }
}

