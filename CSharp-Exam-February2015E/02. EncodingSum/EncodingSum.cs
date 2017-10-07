using System;

namespace _02.EncodingSum
{
    class EncodingSum
    {
        static void Main()
        {
            int m = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            long result = 0;
            text.ToLower();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '@')
                {
                    Console.WriteLine(result);
                    return;
                }
                else if (text[i] >= '0' && text[i] <= '9')
                {
                    result *= (text[i] - '0');
                }
                else if (text[i] >= 'a' && text[i] <= 'z')
                {
                    result += (text[i] - 'a');
                }
                else
                {
                    result %= m;
                }
            }

            Console.WriteLine(result);
        }
    }
}
