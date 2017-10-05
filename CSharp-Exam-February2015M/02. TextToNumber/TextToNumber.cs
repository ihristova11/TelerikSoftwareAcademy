using System;

class TextToNumber
{
    static void Main()
    {
        int m = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();
        char[] arr = text.ToCharArray();
        int result = 0;
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '@')
            {
                break;
            }
            else if (text[i] >= '0' && text[i] <= '9')
            {
                result *= int.Parse(text[i].ToString());
            }
            else if (text[i] >= 'a' && text[i] <= 'z')
            {
                result += (text[i] - 'a');
            }
            else if (text[i] >= 'A' && text[i] <= 'Z')
            {
                result += (text[i] - 'A');
            }
            else
            {
                result %= m;
            }
        }
        Console.WriteLine(result);
    }
}

