using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt02_Aufgabe05.Modelle
{
    internal class Verein: Mitglied
    {
        protected List<Mitglied> mitglieder = new List<Mitglied>();
        private int maxMitglieder;

        public Verein(string setName, int setMaxMitglieder): base(setName, 0) 
        { 
            maxMitglieder = setMaxMitglieder;
        }

        public List<Mitglied> GetMitglieder()
        {
            return mitglieder;
        }

        public void MitgliedHinzufügen(Mitglied newMitglied)
        {
            if(mitglieder.Count < maxMitglieder)
            {
                mitglieder.Add(newMitglied);
            }
            else
            {
                Console.WriteLine("Die Maximale anzahl an Mitgliedern ist erreicht für diesen Verein.");
            }
        }


    }
}
