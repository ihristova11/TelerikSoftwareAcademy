namespace _07.OneSystemToAnyOther
{
    using System;

    class OneSystemToAnyOther
    {
        static void Main()
        {
            int s = int.Parse(Console.ReadLine());
            string n = Console.ReadLine();
            int d = int.Parse(Console.ReadLine());
        }

        public static void ConvertToDecimal(int baseF, int baseS, string n)
        {
            long dec = Convert.ToInt64(n, baseF);
        }
    }
}
