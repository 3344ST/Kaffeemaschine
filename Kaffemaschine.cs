using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffeemaschine
{
    internal class Kaffeemaschine
    {
        
        
        
        
        private int wasserstand;                                // Wasserstand in ml (1000ml = 1l)
        private int bohnenmenge;                                // Bohnenmenge in g
        private static int maxWasserstand = 1000;               // in ml
        private static int maxBohnenmenge = 1000;               // in g

        public int wasserstand1 { get => wasserstand; set => wasserstand = value; }
        public int bohnenmenge1 { get => bohnenmenge; set => bohnenmenge = value; }
        public static int maxWasserstand1 { get => maxWasserstand; }
        public static int maxBohnenmenge1 { get => maxBohnenmenge; }

        internal Kaffeemaschine(int _wasserstand, int _bohnenmenge) 
        {
            this.wasserstand = _wasserstand;
            this.bohnenmenge = _bohnenmenge;
            maxWasserstand = 1000;
            maxBohnenmenge = 1000;
        
        }

        internal int WasserAuf() 
        {
            int wasserauf = maxWasserstand - wasserstand;
            return wasserauf;
        }

        internal int BohnenAuf() 
        {
            int bohnenauf = maxBohnenmenge - bohnenmenge;
            return bohnenauf;
        }

        internal void MakeKaffee(int _wasserstand, int _bohnenmenge, int _anzahlKaffee)                 // ein Kaffee = 100 ml und 50 Gramm
        {
            int restWasser = this.wasserstand - (100 * _anzahlKaffee);
            int restBohnen = this.bohnenmenge - (50 * _anzahlKaffee);
            Console.WriteLine($"Hier Ihr(e) {_anzahlKaffee} Kaffe. Es sind noch {restWasser} ml Wasser\n Sowie {restBohnen} Gramm Bohnen vorhanden ");
        }


       


    }
}