namespace _03.Snacky_the_Snake
{
    using System;
    using System.Linq;

    class Program
    {
        public static char[][] matrix;
        public static int len = 3;
        public static int food = 0;
        public static int rows;
        public static int cols;
        public static string[] directions;
        public static int startCol;
        public static int startRow;

        //----DIRECTIONS----
        //  d -> row + 1
        //  u -> row - 1
        //  l -> col - 1
        //  r -> col + 1

        static void Main()
        {
            //reading the input
            var dimensions = Console.ReadLine()
                .Split(new string[] { "x" }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //getting the dimensions of the matrix
            rows = dimensions[0];
            cols = dimensions[1];
            string line;
            matrix = new char[rows][];

            //get the input line and make it char arr
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = new char[cols];
                line = Console.ReadLine();
                matrix[i] = line.ToCharArray();
            }

            //get the directions in arr
            directions = Console.ReadLine()
                .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            //get the coordinates of the start
            startRow = 0;
            startCol = string.Join("", matrix[startRow]).IndexOf('s');

            GoThroughTheDen();
        }

        public static void GoThroughTheDen()
        {
            int currRow = startRow;
            int currCol = startCol;

            for (int i = 0; i < directions.Length; i++)
            {

                //changing the direction
                switch (directions[i])
                {
                    case "d":
                        currRow += 1;
                        break;
                    case "u":
                        currRow -= 1;
                        break;
                    case "l":
                        currCol -= 1;
                        break;
                    case "r":
                        currCol += 1;
                        break;
                    default: break;
                }

                //changing the length of the snake
                if ((i + 1) % 5 == 0)
                {
                    len--;
                }

                if (len <= 0)
                {
                    Console.WriteLine("Snacky will starve at [{0},{1}]", currRow, currCol);
                    return;
                }
                
                if (currRow >= rows)
                {
                    Console.WriteLine("Snacky will be lost into the depths with length {0}", len);
                    return;
                }

                //check if the snake moves out of the L and R 
                if (currCol > cols - 1)
                {
                    currCol = currCol % cols;
                }
                if (currCol < 0)
                {
                    currCol = (cols + currCol) % cols;
                }

                //going through the matrix and collecting
                switch (matrix[currRow][currCol])
                {
                    case '#':
                        Console.WriteLine("Snacky will hit a rock at [{0},{1}]", currRow, currCol);
                        return;
                    case '*':
                        len++;
                        matrix[currRow][currCol] = '.';
                        break;
                    case '.':
                        break;
                    case 's':
                        Console.WriteLine("Snacky will get out with length {0}", len);
                        return;
                    default: break;
                }

            }
                Console.WriteLine("Snacky will be stuck in the den at [{0},{1}]", currRow, currCol);
        }
    }
}
