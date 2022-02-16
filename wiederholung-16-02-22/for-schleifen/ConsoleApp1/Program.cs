using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 10; a >= 0; a--) 
            {
                for (int i = a; i >= 0; i--)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
