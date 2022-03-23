using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generate/fill variablen
            char[,] b = new char[10, 10];
            Random r = new Random();
            int zufallx = r.Next(1, 10);//Lösung X
            int zufally = r.Next(1, 10);//Lösung Y
            for (int y=0; y <10; y++)
            {
                for (int x = 0; x < 10; x++) 
                {
                    b[x,y] = '~';//Füllt alles mit Wellen
                    b[zufallx, zufally] = '#';//Füllt Lösung mit Platzhalter
                }
            }

            //Gibt Cheat aus
            //Console.WriteLine(zufallx);
            //Console.WriteLine(zufally);

            //Next
            Draw(b);
            Input(zufallx,zufally,b);
        }
        static void Input(int zufallx, int zufally, char[,] b)
        {
            int versuche = 1;//für versuche später
            while (true)//wiederholt aber später kommt ein break
            {
                //Input
                Console.Write("Bitte X-Koordinate angeben: ");
                int inputx = Convert.ToInt32(Console.ReadLine());
                Console.Write("Bitte Y-Koordinate angeben: ");
                int inputy = Convert.ToInt32(Console.ReadLine());

                //Use Input
                //treffer
                if (inputx == zufallx & inputy == zufally)//input wird mit der Lösung verglichen
                {
                    b[zufallx, zufally] = 'x';//Platzhalter/Lösung wird mit x ersetzt
                    Console.Clear();
                    Draw(b);
                    Console.WriteLine("Feuere auf {0}, {1}: Treffer!",inputx,inputy);

                    //Versuche es wird auch überprüft, ob man nur einen Versuch gebraucht hat mit alternativer Nachricht
                    if (versuche != 1)
                    {
                        Console.WriteLine("Das hat {0} Versuche gebraucht!", versuche);
                    }
                    else
                    {
                        Console.WriteLine("Das hat einen Versuch gebraucht! Cheater");
                    }

                    break;
                }
                //daneben
                else
                {
                    Console.WriteLine("Feuere auf {0}, {1}: Daneben...", inputx, inputy);
                    versuche++;
                    b[inputx-1, inputy-1] = 'o';
                    Console.Clear();
                    Draw(b);
                }
            }
        }

        static void Draw(char[,] b)
        {
            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    //Platzhalter wird mit if/else mit welle ersetzt dargestellt aber bleibt im Array, bis es mit einem anderen char ersetzt wurde (in dem fall x)
                    if ((b[x, y] != '#'))
                    {
                        Console.Write(b[x, y] + "\t");
                    }
                    else
                    {
                        Console.Write("~\t");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
