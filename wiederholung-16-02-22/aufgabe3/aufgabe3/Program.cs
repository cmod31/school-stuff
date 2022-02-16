using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            Console.Write("Schreiben sie den Preis: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 100)
            {
                if (a > 500)
                {
                    double b;
                    double c;
                    b = a / 10;
                    c = a - b;
                    Console.WriteLine(c);
                }
                else
                {
                    double b;
                    double c;
                    b = a / 100 * 5;
                    c = a - b;
                    Console.Write(c);
                }
            }
            else
            {
                Console.Write(a);
            }
            Console.Read();
        }
    }
}