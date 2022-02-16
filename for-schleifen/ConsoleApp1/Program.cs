using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            for (a = 10; a >= 0; a--) 
            {
                for (int i = a; i >= 0; i--)
                {
                    Console.Write(i);
                }
                Console.WriteLine("");
            }

            Console.Read();
        }
    }
}
