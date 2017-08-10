using System;

namespace _01.SayHello
{
    class SayHello
    {
        static void Main()
        {
            string name = Console.ReadLine();
            Congrats(name);
        }

        public static void Congrats(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
