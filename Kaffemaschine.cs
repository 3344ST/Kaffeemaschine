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
        private int anzahlKaffee;                                
        private static int maxWasserstand = 1000;               // in ml
        private static int maxBohnenmenge = 1000;               // in g


        public int wasserstand1 { get => wasserstand; set => wasserstand = value; }
        public int bohnenmenge1 { get => bohnenmenge; set => bohnenmenge = value; }

        public int anzahlKaffee1 { get => anzahlKaffee; set => anzahlKaffee = value; }
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

        internal void MakeKaffee(int _anzahlKaffee)                 // ein Kaffee = 100 ml und 50 Gramm
        {
            anzahlKaffee = _anzahlKaffee;

            if ((GenugWasser() == true) && GenugBohnen() == true)
            {
                int restWasser = this.wasserstand - (100 * _anzahlKaffee);
                int restBohnen = this.bohnenmenge - (50 * _anzahlKaffee);
                Console.WriteLine($"Hier Ihr(e) {_anzahlKaffee} Kaffee. Es sind noch {restWasser} ml Wasser\nSowie {restBohnen} Gramm Bohnen vorhanden ");
            }
            else if ((GenugWasser() == false) && GenugBohnen() == false) 
            {
                Console.WriteLine("Bitte Wasser und Bohnen auffüllen");
            }
            else if (GenugWasser() == false)
            {
                Console.WriteLine("Bitte Wasser auffüllen");
            }
            else if (GenugBohnen() == false)
            {
                Console.WriteLine("Bitte Bohnen auffüllen");
            } 
        }

        internal bool GenugWasser()
        {
            if (this.wasserstand > (100 * anzahlKaffee)) return true;
            
            else if (this.wasserstand < (100 * anzahlKaffee)) return false;
           
            return false;
        }

        
        internal bool GenugBohnen() 
        {

            if (this.bohnenmenge > (50 * anzahlKaffee)) return true;
           
            else if (this.bohnenmenge < (100 * anzahlKaffee)) return false;
            
            return false;
        }





    }
}