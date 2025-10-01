using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt02_Aufgabe04.Modelle
{
    internal class Reihenschaltung: WiederstandNetz
    {
        public Reihenschaltung(string setName, double wert1, double wert2, params double[] werteRest) : base (setName, wert1, wert2, werteRest)
        {
            
            WiederstandBerechnung(wiederstandImNetz);
        }
        public override void WiederstandBerechnung(List<Wiederstand> wiederList)
        {
            Console.Write("Rp: ");

            double gesammtWert = 0;
            for(int i = 0; i < wiederList.Count; i++)
            {
                gesammtWert = gesammtWert + wiederList[i].GetWiederstandWert();
                Console.Write($"{wiederList[i].GetWiederstandName()} + ");
            }
            Console.WriteLine();
        }
    }
}
