using System;

class FillTheMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string way = Console.ReadLine();
        int[,] matrix = new int[n, n];

        int counter = 1;
        switch (way)
        {
            case "a":
                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    for (int row = 0; row < matrix.GetLength(1); row++)
                    {
                        matrix[row, col] = counter;
                        counter++;
                    }
                }

                break;

            case "b":
                break;

            case "c":
                break;

            case "d":
                break;

            default:
                break;
        }

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(string.Format("{0} ", matrix[row, col]));
            }
            Console.WriteLine();
        }
    }
}

