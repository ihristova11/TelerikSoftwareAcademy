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
                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    for (int row = 0; row < matrix.GetLength(1); row++)
                    {
                        if(col % 2 == 0)
                        {
                            matrix[row, col] = (row + 1) + n * col;
                        }
                        else
                        {
                            matrix[row, col] = (col + 1) * n - row;
                        }
                    }
                }
                break;

            case "c":
                int row = n - 1, col = 0;
                matrix[n - 1, 0] = 1;
                matrix[0, n - 1] = n * n;

                while(row != 0 && col != n - 1)
                {

                }

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
                if (col < matrix.GetLength(1) - 1)
                {
                    Console.Write(string.Format("{0} ", matrix[row, col]));
                }
                else
                {
                    Console.Write(string.Format("{0}", matrix[row, col]));
                }
            }
            Console.WriteLine();
        }
    }
}

