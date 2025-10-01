using AufgabenBlatt01_Aufgabe01.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt01_Aufgabe01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Socke socke1 = new Socke("Grün");

            socke1.Wasche();
            socke1.Trockne();
            socke1.Ausgabe();

        }
    }
}
