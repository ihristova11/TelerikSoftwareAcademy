using System;

class Printing
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); //number of students in the academy
        int s = int.Parse(Console.ReadLine()); //sheets that should be printed for a student
        double p = double.Parse(Console.ReadLine()); //price of one realm (box with paper sheets)

        Console.WriteLine("{0:f2}", (n * s * p / 500.0));
    }
}

