namespace _02.DancingMoves
{
    using System;
    using System.Linq;

    class DancingMoves
    {
        public static string line;
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
            }

        }
    }
}
