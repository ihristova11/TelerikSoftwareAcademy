namespace _02.Kitty
{
    using System;
    using System.Linq;
    using System.Text;

    class Kitty
    {
        static int position = 0;
        static int direction = 0;
        static int souls = 0;
        static int deadlocks = 0;
        static int food = 0;
        static int[] directions;
        static StringBuilder path;
        static void Main()
        {
            path = new StringBuilder(Console.ReadLine());
            directions = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


        }

        public static void CheckPosition()
        {
            for (int direction = 0; direction < directions.Length; direction++)
            {
                position += directions[direction];

                if(position < 0)
                {
                    position += path.Length;
                }
                else if(position > path.Length - 1)
                {
                    position -= path.Length;
                }
            }
        }
    }
}
