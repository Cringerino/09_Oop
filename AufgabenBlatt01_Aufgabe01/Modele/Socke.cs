using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt01_Aufgabe01.Modele
{
    internal class Socke
    {
        private string farbe;
        private bool trocken;
        private bool sauber;

        public Socke(string setFarbe)
        {
            farbe = setFarbe;
            trocken = true;
            sauber = false;
        }

        public void Wasche()
        {
            this.sauber = true;
            this.trocken = false;
        }

        public void Trockne()
        {
            this.trocken = true;
        }

        public void Ausgabe()
        {
            string sauberCheck = "";
            string trockenCheck = "";
            if (!this.trocken)
            {
                trockenCheck = " nicht";
            }
            if (!this.sauber)
            {
                sauberCheck = " nicht";
            }
            Console.WriteLine($"Die Socke mit der Farbe {this.farbe} ist{trockenCheck} trocken und{sauberCheck} sauber.");
        }


    }

}
