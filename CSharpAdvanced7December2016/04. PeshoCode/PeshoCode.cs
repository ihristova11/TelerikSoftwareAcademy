﻿namespace _04.PeshoCode
{
    using System;

    class PeshoCode
    {
        static void Main()
        {
            string word = Console.ReadLine();
            
            int numberOfLines = int.Parse(Console.ReadLine());
            string[] lines = new string[numberOfLines];

            for (int i = 0; i < numberOfLines; i++)
            {
                lines[i] = Console.ReadLine();
            }

            string text = string.Join(" ", lines);

            //Console.WriteLine(text);
        }
    }
}
