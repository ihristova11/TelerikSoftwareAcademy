namespace _03.SneakyTheSnake
{
    using System;
    using System.Linq;

    class SneakyTheSnake
    {
        //messages
        public static string getOut = "Sneaky is going to get out with length {0}";
        public static string hitRock = "Sneaky is going to hit a rock at [{0},{1}]";
        public static string lostIntoDepths = "Sneaky is going to be lost into the depths with length {0}";
        public static string starve = "Sneaky is going to starve at [{0},{1}]";
        public static string stuckInDen = "Sneaky is going to be stuck in the den at [{0},{1}]";

        public static char[][] matrix;
        public static string[] directions;
        public static int len = 3;

        public static int rows;
        public static int cols;

        public static int startRow;
        public static int startCol;

        //----DIRECTIONS----
        //  s -> row + 1
        //  w -> row - 1
        //  a -> col - 1
        //  d -> col + 1
        
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
            matrix = new char[rows][];

            FillTheMatrix();

            //get the directions in arr
            directions = Console.ReadLine()
                .Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            //get the coordinates of the start
            startRow = 0;
            startCol = string.Join("", matrix[startRow]).IndexOf('e');

            GoThroughMatrix();
        }

        public static void FillTheMatrix()
        {
            //get the input line and make it char arr
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = new char[cols];
                matrix[i] = Console.ReadLine().ToCharArray();
            }
        }

        public static void GoThroughMatrix()
        {
            int currRow = startRow;
            int currCol = startCol;
            for (int index = 0; index < directions.Length; index++)
            {
                //changing the direction
                switch (directions[index])
                {
                    case "s":
                        currRow += 1;
                        break;
                    case "w":
                        currRow -= 1;
                        break;
                    case "a":
                        currCol -= 1;
                        break;
                    case "d":
                        currCol += 1;
                        break;
                    default: break;
                }

                //changing the length of the snake
                if ((index + 1) % 5 == 0)
                {
                    len--;
                }

                if (len <= 0)
                {
                    Console.WriteLine(starve, currRow, currCol);
                    return;
                }

                //check if the snake moves out of the L and R 
                if (currRow >= rows)
                {
                    Console.WriteLine(lostIntoDepths, len);
                    return;
                }

                if (currCol < 0)
                {
                    currCol = (cols + currCol) % cols;
                }

                if (currCol > cols - 1)
                {
                    currCol = currCol % cols;
                }

                // going through the matrix and collecting
                switch (matrix[currRow][currCol])
                {
                    case '%':
                        Console.WriteLine(hitRock, currRow, currCol);
                        return;
                    case '@':
                        len++;
                        matrix[currRow][currCol] = '-';
                        break;
                    case '-':
                        break;
                    case 'e':
                        Console.WriteLine(getOut, len);
                        return;
                    default: break;
                }
            }
            Console.WriteLine(stuckInDen, currRow, currCol);
        }
    }
}