namespace _01.Frames
{
    using System;

    class Frames
    {
        static void Main()
        {
            byte n = byte.Parse(Console.ReadLine());
            byte differentFrames = n;
            string[] lines = new string[n];
            byte numberInLine = byte.Parse((n - 1).ToString());
            int result = 1;
            for (int i = 0; i < n; i++)
            {
                lines[i] = Console.ReadLine();
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if(lines[i] == lines[j])
                    {
                        differentFrames--;
                    }
                }
            }

            if (differentFrames == 0) differentFrames = 1;

            for (byte i = differentFrames; i >= 1; i--)
            {
                result *= i;
            }

            for (int j = n - 1; j >= 1; j--)
            {
                result *= j;
            }
            //Console.WriteLine(differentFrames);
            Console.WriteLine(result);
            //Console.WriteLine(numberInLine);
        }
    }
}
