namespace _04.HexadecimalToDecimal
{
    using System;

    class HexadecimalToDecimal
    {
        static void Main()
        {
            //reading hexadecimal
            string hex = Console.ReadLine();
            long dec = Convert.ToInt64(hex, 16);
            // converting to dec
            //long dec = 0;
            //int k = 0;
            //for (int i = hex.Length - 1; i >= 0; i--)
            //{
            //    if(i >= 0 && i <= 9)
            //    {
            //        dec += long.Parse(Math.Pow(16, i).ToString()) * long.Parse(hex[i].ToString());
            //    }
            //    else
            //    {
            //        switch(hex[i])
            //        {
            //            case 'A':
            //                k = 10;
            //                break;
            //            case 'B':
            //                k = 11;
            //                break;
            //            case 'C':
            //                k = 12;
            //                break;
            //            case 'D':
            //                k = 13;
            //                break;
            //            case 'E':
            //                k = 14;
            //                break;
            //            case 'F':
            //                k = 15;
            //                break;
            //            default: break;
            //        }

            //        dec += long.Parse(Math.Pow(16, i).ToString()) * long.Parse(k.ToString());
            //    }
            //}

            Console.WriteLine(dec);
        }
    }
}
