using System;

namespace _03.EnglishDigit
{
    class EnglishDigit
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(DigitAsWord(LastDigit(number)));
        }

        static int LastDigit(int number)
        {
            int digit = number % 10;

            return digit;
        }

        public static string DigitAsWord(int digit)
        {
            string word = "";
            switch(digit)
            {
                case 0:
                    word = "zero";
                    break;
                case 1:
                    word = "one";
                    break;
                case 2:
                    word = "two";
                    break;
                case 3:
                    word = "three";
                    break;
                case 4:
                    word = "four";
                    break;
                case 5:
                    word = "five";
                    break;
                case 6:
                    word = "six";
                    break;
                case 7:
                    word = "seven";
                    break;
                case 8:
                    word = "eight";
                    break;
                case 9:
                    word = "nine";
                    break;
                default:
                    word = "error";
                    break;
            }

            return word;
        }
    }
}
