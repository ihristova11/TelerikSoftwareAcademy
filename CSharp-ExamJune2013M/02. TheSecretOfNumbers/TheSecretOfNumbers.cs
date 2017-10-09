using System;
using System.Numerics;

class TheSecretOfNumbers
{
    static void Main()
    {
        string number = Console.ReadLine();
        int specialSum = 0;
        bool hasSpecialSum = true;
        string secretAlphaSequence = "";
        for (int i = number.Length - 1; i >= 0; i--)
        {
            if ((number.Length - i) % 2 == 1) //odd positions case
            {
                specialSum += int.Parse(number[i].ToString()) * (number.Length - i) * (number.Length - i);
            }
            else //even positions case 
            {
                specialSum += (number.Length - i) * int.Parse(number[i].ToString()) * int.Parse(number[i].ToString());
            }
        }
        int lastDigit = specialSum % 10;
        if (lastDigit == 0)
        {
            hasSpecialSum = false;
            secretAlphaSequence += number + " has no secret alpha-sequence";
        }
        else
        {
            int r = specialSum % 26;
            int j = 0;
            int letter;
            while (j < lastDigit)
            {
                letter = 'A' + r + j;
                if (letter > 'Z')
                {
                    letter = letter - 'Z' + 'A' - 1;
                }
                secretAlphaSequence += (char)(letter);
                j++;

            }
        }
        Console.WriteLine(secretAlphaSequence);
        Console.WriteLine(specialSum);
        //Console.WriteLine(specialSum % 26 + 1);
        //Console.WriteLine(specialSum);
    }
}

