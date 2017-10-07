using System;

class Decoding
{
    static void Main()
    {
        int salt = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();
        decimal encodedChar = 0;
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '@')
            {
                break;
            }
            else if ((text[i] >= 'a' && text[i] <= 'z') || (text[i] >= 'A' && text[i] <= 'Z'))
            {
                encodedChar += text[i] * salt + 1000;
            }
            else if(text[i] >= '0' && text[i] <= '9')
            {
                encodedChar += text[i] + salt + 500;
            }

            if(i % 2 == 0)
            {
                encodedChar = Math.Round(encodedChar / 100, 2);
            }
            else
            {
                encodedChar *= 100;
            }
            Console.WriteLine(encodedChar);
        }
    }
}

