namespace _04.GoshoCode
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Text;

    class GoshoCode
    {       
        static void Main()
        {
            BigInteger sum = new BigInteger();
            sum = 0;
            var keyword = Console.ReadLine();
            var sentencesNumber = int.Parse(Console.ReadLine());
            var lines = new List<string>();

            for (int line = 0; line < sentencesNumber; line++)
            {
                lines.Add(Console.ReadLine());
            }

            var text = string.Join(" ", lines);


            var keywordPos = text.IndexOf(keyword);
            var sentenceBeginning = -1;

            for (int index = keywordPos; index > 0; index--)
            {
                if (text[index] >= 65 && text[index] <= 90)
                {
                    sentenceBeginning = index;
                    break;
                }
            }

            string targetSubstring = string.Empty;

            for (int index = keywordPos + keyword.Length; index < text.Length; index++)
            {
                if (text[index] == '.')
                {
                    var sentanceEnd = index;
                    targetSubstring = text.Substring(keywordPos + keyword.Length, sentanceEnd - (keywordPos + keyword.Length));
                    break;
                }

                if (text[index] == '!')
                {
                    var sentanceEnd = index;
                    targetSubstring = text.Substring(sentenceBeginning, keywordPos - sentenceBeginning);
                    break;
                }
            }

            var gluedSubstring = targetSubstring.Replace(" ", string.Empty);
            BigInteger result = 0;

            foreach (var character in gluedSubstring)
            {
                result += character * keyword.Length;
            }

            Console.WriteLine(result);
        }
    }
}
