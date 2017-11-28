namespace _02.Kitty
{
    using System;
    using System.Linq;

    class Kitty
    {
        static void Main()
        {
            string path = Console.ReadLine();
            int[] directions = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int position = 0;
            int souls = 0, deadlocks = 0, food = 0;
            bool[] beenThere = new bool[directions.Length];
            for (int i = 0; i < directions.Length; i += position)
            {
                if(i < 0 || i > directions.Length - 1)
                {

                }
            }

        }
    }
}
