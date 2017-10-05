using System;

class IndexOfLetters
{
    static void Main()
    {
        string input = Console.ReadLine();
        char[] letters = new char[26];
        for (int i = 0; i < letters.Length; i++)
        {
            letters[i] = (char)('a' + i);
        }

        for (int j = 0; j < input.Length; j++)
        {
            Console.WriteLine(Array.IndexOf(letters, input[j]));
        }
        
    }
}
