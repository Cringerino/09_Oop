using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt02_Aufgabe04.Modelle
{
    internal class Wiederstand
    {
        private double wiederstandWert;
        private string wiederstandName;

        public Wiederstand(string setName, double setWiederstand)
        {
            wiederstandName = setName;
            wiederstandWert = setWiederstand;
        }

        public double GetWiederstandWert()
        {
            return wiederstandWert;
        }

        public string GetWiederstandName()
        {
            return wiederstandName;
        }
    }
}
