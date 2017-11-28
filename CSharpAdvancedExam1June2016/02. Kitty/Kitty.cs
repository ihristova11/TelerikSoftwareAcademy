namespace _02.Kitty
{
    using System;
    using System.Linq;
    using System.Text;

    class Kitty
    {
        static void Main()
        {
            StringBuilder path = new StringBuilder(Console.ReadLine());
            int[] directions = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int position = 0;
            int souls = 0, deadlocks = 0, food = 0;
            //bool[] beenThere = new bool[directions.Length];
            for (int direction = 0; direction < directions.Length; direction++)
            {
                if (direction == 0) { position = 0; }
                else
                {
                    position += directions[direction];
                }

                //check if index out of range
                if (position < 0)
                {
                    position += (path.Length - 1);
                }
                else if (position > path.Length - 1)
                {
                    position -= (path.Length - 1);
                }

                switch (path[position])
                {
                    case '@':
                        souls++;
                        path[position] = 'v';
                        break;
                    case 'x':
                        deadlocks++;
                        if (position % 2 == 0 && souls > 0)
                        {
                            souls--;
                            deadlocks++;
                            path[position] = 'v';
                        }
                        else if (position % 2 == 1 && food > 0)
                        {
                            food--;
                            deadlocks++;
                            path[position] = 'v';
                        }
                        else
                        {
                            Console.WriteLine("You are deadlocked, you greedy kitty!");
                            Console.WriteLine("Jumps before deadlock: {0}", direction);
                            return;
                        }
                        break;
                    case '*':
                        food++;
                        path[position] = 'v';
                        break;
                    default:
                        throw new ArgumentException("ERROR");
                        break;
                }
            }
            Console.WriteLine("Coder souls collected: {0}", souls);
            Console.WriteLine("Food collected: {0}", food);
            Console.WriteLine("Deadlocks: {0}", deadlocks);

        }
    }
}
