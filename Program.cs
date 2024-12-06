namespace Kaffeemaschine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kaffeemaschine maschine1 = new Kaffeemaschine(600, 300);

            int wasser = maschine1.WasserAuf();
            
            Console.WriteLine($"Bitte füllen Sie {wasser} ml Wasser nach");

            int bohnen = maschine1.BohnenAuf();
            Console.WriteLine($"Bitte füllen Sie {bohnen} Gramm Bohnen nach");

            maschine1.MakeKaffee(600, 300, 4);          //Wasserstand, Bohnenmenge, Anzahl Kaffees
            
        }
    }
}
