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
                specialSum += int.Parse(number[i].ToString()) * i * i;
            }
            else //even positions case 
            {
                specialSum += i * int.Parse(number[i].ToString()) * int.Parse(number[i].ToString());
            }
        }
        int lastDigit = specialSum %= 10;
        if(lastDigit == 0)
        {
            hasSpecialSum = false;
        }
        else
        {
            int r = specialSum % 26;
        }
    }
}

