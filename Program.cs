using System.Runtime.Intrinsics.X86;

namespace Kaffeemaschine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Kaffeemaschine maschine1 = new Kaffeemaschine(1900, 950);  //WasserMax: 2000; BohnenMax: 1000
            
            while (true)     //Menü Erstellung
            {
                Console.WriteLine($"Bitte wählen Sie (1 - 2 - 3):\n\n1. Kaffee ausgeben\n2. Kaffeemaschinen Status\n3. Beenden");
                string input = Console.ReadLine();
                int wasser = 0;
                int bohnen = 0;

                if (input == "1")
                {
                    Console.WriteLine("Wie viel Kaffee?");
                    int anzahl = Convert.ToInt32(Console.ReadLine());
                    maschine1.MakeKaffee(anzahl);
                    maschine1.WasserNach(anzahl);
                    maschine1.BohnenNach(anzahl);
                    maschine1.Zubereitung();
                }
                else if (input == "2") 
                {
                    wasser = maschine1.WasserAuf();
                    Console.WriteLine($"Bitte füllen Sie {wasser}ml Wasser nach");
                    bohnen = maschine1.BohnenAuf();
                    Console.WriteLine($"Bitte füllen Sie {bohnen} Gramm Bohnen nach");
                }
                else if (input == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Falsche Eingabe");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

        }
        
    }
}



         




