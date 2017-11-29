namespace _03.LoverOfThree
{
    using System;
    using System.Linq;

    class LoverOfThree
    {
        static int[,] matrix;
        static int[] rows = { -1, -1, 1, 1 };
        static int[] cols = { -1, 1, 1, -1 };

        static int GetMoveDirection(string direction)
        {
            switch(direction)
            {
                case "LU": return 0;
                    break;
                case "UL": return 0;
                    break;
                case "RU":return 1;
                    break;
                case "UR":return 1;
                    break;
                case "RD":return 2;
                    break;
                case "DR":return 2;
                    break;
                case "LD":return 3;
                    break;
                case "DL":return 3;
                    break;

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
        }
    }
}
