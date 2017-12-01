namespace _02.DancingMoves
{
    using System;
    using System.Linq;

    class DancingMoves
    {
        public static string line;
        public static int sum = 0;
        static void Main()
        {
            //reading the input
            var arr = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            line = "";


        }

        public static void CalculateSum(int[] arr)
        {
            while (line != "stop")
            {
                //getting the line elements for the task
                line = Console.ReadLine();
                var instructions = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                int repeats = int.Parse(instructions[0]);
                string direction = instructions[1];
                int steps = int.Parse(instructions[2]);

                int position = 0;

                for (int i = 1; i <= repeats; i++)
                {
                    if (direction == "left")
                    {
                        position -= steps;
                    }
                    else if(direction == "right")
                    {
                        position += steps;
                    }

                    //if position is out of boundaries
                    while(position < 0)
                    {
                        position += arr.Length;
                    }

                    while(position > arr.Length - 1)
                    {
                        position -= arr.Length;
                    }

                }
            }

        }
    }
}
