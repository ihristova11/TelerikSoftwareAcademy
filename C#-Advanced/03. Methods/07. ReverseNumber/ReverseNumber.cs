using System;
namespace _07.ReverseNumber
{
    class ReverseNumber
    {
        static void Main()
        {
            decimal n = decimal.Parse(Console.ReadLine());
            ReverseIt(n);
        }

        static void ReverseIt(decimal number)
        {

            char[] digits = number.ToString().ToCharArray();
            char[] reversedNum = new char[digits.Length];

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                reversedNum[digits.Length - i - 1] = digits[i];
                //Console.WriteLine(reversedNum[i]);
            }

            Console.WriteLine(string.Join("", reversedNum));
        }
    }
}
