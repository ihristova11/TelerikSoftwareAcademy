namespace _03.LoverOfThree
{
    using System;
    using System.Linq;

    class LoverOfThree
    {
        static int[,] matrix;
        static int[] rows = { -1, -1, 1, 1 };
        static int[] cols = { -1, 1, 1, -1 };
        static int r;
        static int c;
        static int sum = 0;
        static int GetMoveDirection(string direction)
        {
            switch (direction)
            {
                case "LU":
                    return 0;
                case "UL":
                    return 0;
                case "RU":
                    return 1;
                case "UR":
                    return 1;
                case "RD":
                    return 2;
                case "DR":
                    return 2;
                case "LD":
                    return 3;
                case "DL":
                    return 3;

                default: throw new ArgumentException();
            }
        }

        static void Main()
        {
            // reading the input
            int[] dimensions = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            r = dimensions[0];
            c = dimensions[1];
            matrix = new int[r, c];

            //FILL THE MATRIX
            for (int i = r - 1; i >= 0; i--)
            {
                for (int j = 0; j < c; j++)
                {
                    matrix[i, j] = (r - 1 - i) * 3 + j * 3;
                }
            }

            int directionsNumber = int.Parse(Console.ReadLine());

            ////print the matrix
            //for (int i = 0; i < r; i++)
            //{
            //    for (int j = 0; j < c; j++)
            //    {
            //        Console.Write(matrix[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            for (int i = 0; i < directionsNumber; i++)
            {
                var input = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                var dir = input[0];
                var repeats = int.Parse(input[1]);

                var moveDirection = GetMoveDirection(dir);
                var row = r - 1;
                var col = 0;

                for (int j = 0; j < repeats - 1; j++)
                {
                    row += rows[moveDirection];
                    col += cols[moveDirection];

                    if (row > r - 1 || col > c - 1 || row < 0 || col < 0)
                    {
                        row -= rows[moveDirection];
                        col -= cols[moveDirection];
                        break;
                    }
                    else
                    {
                        sum += matrix[row, col];
                        matrix[row, col] = 0;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
