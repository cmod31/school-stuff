using System;

namespace arraysab
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] feldA = new double[10];
            for (int i = 0; i < feldA.Length; i++)
            {
                feldA[i] = 7;
                Console.WriteLine(feldA[i]);
            }

            string[] namen = new string[5] { "amogus", "herobrine", "shreck", "Dennis Ziolkowski", "Siegfried"};
            for (int i = 0; i < namen.Length; i++)
            {
                Console.WriteLine(namen[i]);
            }
          
            Console.Write("Geben Sie eine zahl ein: ");
            int[] feldB = new int[Convert.ToInt32(Console.ReadLine())];
            Random r = new Random();
            int summeB = 0;
            for (int j = 0; j < feldB.Length; j++)
            {
                int random1 = r.Next(99);
                feldB[j] = random1;
                Console.WriteLine(feldB[j]);
                summeB = feldB[j] + feldB[j++];
            }
            Console.WriteLine("Summe: {0}", summeB);
            Console.Read();
            //funktioniert nicht der teilt die eingabe durch 2 irgendwie
        }
    }
}
