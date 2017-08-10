using System;

namespace _03.CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main()
        {
            char[] str1 = Console.ReadLine().ToCharArray();
            char[] str2 = Console.ReadLine().ToCharArray();
            int len;
            string type = "=";


            if (str1.Length > str2.Length)
            {
                len = str2.Length;
            }
            else
            {
                len = str1.Length;
            }

            for (int i = 0; i < len; i++)
            {
                if (str1[i] > str2[i])
                {
                    type = ">";
                    break;
                }
                else if (str2[i] > str1[i])
                {
                    type = "<";
                    break;
                }
            }

            if (type == "=")
            {
                if (str1.Length < str2.Length) type = "<";
                if (str1.Length > str2.Length) type = ">";
            }
            Console.WriteLine(type);
        }
    }
}
