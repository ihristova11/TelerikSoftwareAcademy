namespace _03.Snacky_the_Snake
{
    using System;
    using System.Linq;

    class Program
    {
        public static char[][] matrix;
        static void Main()
        {
            //reading the input
            var dimensions = Console.ReadLine()
                .Split(new string[] { "x" }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //getting the dimensions of the matrix
            var rows = dimensions[0];
            var cols = dimensions[1];
            string line;
            matrix = new char[rows][];

            for (int i = 0; i < rows; i++)
            {
                matrix[i] = new char[cols];
                line = Console.ReadLine();
                matrix[i] = line.ToCharArray();
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
