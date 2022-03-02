using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace AB_Array_Prüfung
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Geben Sie eine zahl ein: ");
            int[] neunundsechzig = new int[Convert.ToInt32(Console.ReadLine())];
            Random r = new Random();

            for (int i = 0; i < neunundsechzig.Length; i++)
            {
                int random1 = r.Next(99);
                neunundsechzig[i] = random1;
                Console.WriteLine(neunundsechzig[i]);
            }
            using (System.Diagnostics.Process pProcess = new System.Diagnostics.Process())
            {
                pProcess.StartInfo.FileName = @"C:\Users\User\source\repos\hurensohn\hurensohn\bin\Debug\hurensohn.exe";
                pProcess.Start();
                pProcess.WaitForExit();
            }
            Console.Read();
        }
    }
}
