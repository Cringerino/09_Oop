using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt03_Aufgabe04.Modelle
{
    internal class Ninja
    {
        protected int waffe;

        public Ninja(int waffenWahl) 
        { 
            waffe = waffenWahl;
        }

        public void Angriff(string ziel)
        {
            if (waffe <= 1 )
            {
                Katana ichiban = new Katana();
                ichiban.Treffen(ziel);
            }
            else if (waffe >= 2)
            {
                Shuriken kuro = new Shuriken();
                kuro.Treffen(ziel);
            }
        }
    }
}
