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

        static int GetMoveDirection(string direction)
        {
            switch (direction)
            {
                case "LU":
                    return 0;
                    break;
                case "UL":
                    return 0;
                    break;
                case "RU":
                    return 1;
                    break;
                case "UR":
                    return 1;
                    break;
                case "RD":
                    return 2;
                    break;
                case "DR":
                    return 2;
                    break;
                case "LD":
                    return 3;
                    break;
                case "DL":
                    return 3;
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
            r = dimensions[0];
            c = dimensions[1];
            int directionsNumber = int.Parse(Console.ReadLine());

            //FILL THE MATRIX

                
            for (int i = 0; i < directionsNumber; i++)
            {
                var input = Console.ReadLine().Split(new string[] { "" }, StringSplitOptions.RemoveEmptyEntries);
                var dir = input[0];
                var repeats = input[1];

                var moveDirection = GetMoveDirection(dir);
                var row = r - 1;
                var col = 0;

                for (int j = 0; j < repeats; j++)
                {
                    
                }
            }
        }
    }
}
