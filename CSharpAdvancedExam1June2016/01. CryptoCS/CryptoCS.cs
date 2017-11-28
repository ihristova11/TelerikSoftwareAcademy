namespace _01.CryptoCS
{
    using System;
    using System.Linq;

    class CryptoCS
    {
        static void Main()
        {
            //reading the input
            string firstNumber = Console.ReadLine();
            char action = char.Parse(Console.ReadLine());
            string secondNumber = Console.ReadLine();

            //Console.WriteLine(ConvertToNBase(685, 9));
            // Console.WriteLine(ConvertTo10Base(2, "11")); 
            var resultIn10Base = int.Parse(ConvertTo10Base(26, ConvertFromDigit(firstNumber)));

            if (action == '-')
            {
                resultIn10Base -= int.Parse(ConvertTo10Base(7, secondNumber));
            }
            else
            {
                resultIn10Base += int.Parse(ConvertTo10Base(7, secondNumber));
            }

            Console.WriteLine(ConvertToNBase(resultIn10Base, 9));
        }

        public static string ConvertFromDigit(string numberAsString)
        {
            string convertedNumber = "";
            for (int i = 0; i < numberAsString.Length; i++)
            {
                convertedNumber += (numberAsString[i] - 'a' - 1).ToString();
            }
            return convertedNumber;
        }

        public static string ConvertTo10Base(int currBase, string numberToConvert)
        {
            int result = 0;
            for (int i = numberToConvert.Length - 1; i >= 0; i--)
            {
                result += int.Parse(numberToConvert[i].ToString()) * (int)Math.Pow(currBase, numberToConvert.Length - 1 - i);
            }

            return result.ToString();
        }

        public static string ConvertToNBase(int decNumber, int currBase)
        {
            string converted = "";
            while (decNumber > 0)
            {
                converted += decNumber % currBase;
                decNumber /= currBase;
            }
            var arr = converted.ToArray();
            Array.Reverse(arr);
            return string.Join("", arr);
        }
    }
}
