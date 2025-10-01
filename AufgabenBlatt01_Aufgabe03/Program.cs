using AufgabenBlatt01_Aufgabe03.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt01_Aufgabe03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Filiale netto = new Filiale("Braunschweig", 200, 50);

            netto.Buy();
            netto.Sell();
            netto.Sell();
            netto.Output();
        }
    }
}
