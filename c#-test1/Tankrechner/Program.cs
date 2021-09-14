using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tankrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Deutscher Qualitäts-Rechner";
            starteTankkostenBerechnung();
            Console.ReadKey();
        }


        static void starteTankkostenBerechnung ()
        {
            Console.Title = "Guter Taschenrechner";

            double zahl1 = 0; //1. variablen deklarieren - Variablendeklaration
            double summe = 0;
            double x = Convert.ToDouble(1.30);

            //ruhe ole
            Console.WriteLine("Bitte geben sie ein wie viel Liter sie tanken wollen: ");
            zahl1 = Convert.ToDouble(Console.ReadLine());
            summe = zahl1 * x;
            Console.WriteLine("Das Tanken kostet {0} Euro",summe);
            Console.ReadLine();
        }
    }
}
