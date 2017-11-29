namespace _03.LoverOfThree
{
    using System;
    using System.Linq;

    class LoverOfThree
    {
        static int[] rows = { -1, -1, 1, 1 };
        static int[] cols = { -1, 1, 1, -1 };

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
            int[] arrNum = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int rowsCount = arrNum[0];
            int colsCount = arrNum[1];

            var matrix = new int[rowsCount, colsCount];

            // fill the matrix
            for (int i = rowsCount - 1; i >= 0; i--)
            {
                for (int j = 0; j < colsCount; j++)
                {
                    matrix[i, j] = (rowsCount - 1 - i) * 3 + j * 3;
                }
            }

            int movesCount = int.Parse(Console.ReadLine());

            int row = rowsCount - 1;
            int col = 0;

            int sum = 0;

            for (int i = 0; i < movesCount; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var dir = input[0];
                var repeat = int.Parse(input[1]);

                var moveDir = GetMoveDirection(dir);

                for (int j = 0; j < repeat - 1; j++)
                {
                    row += rows[moveDir];
                    col += cols[moveDir];

                    if (row > rowsCount - 1 || row < 0 || col > colsCount - 1 || col < 0)
                    {
                        row -= rows[moveDir];
                        col -= cols[moveDir];
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