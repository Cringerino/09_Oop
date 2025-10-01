using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt02_Aufgabe01.Modelle
{
    internal class Auto
    {
        protected string kennzeichen = "DO-OM 3";
        protected double kilometerstand = 0;
        protected int sitzplätze = 5;
        protected bool antenne = true;

        public Auto(string setKennzeichen, int setSitzplätze)
        {
            kennzeichen = setKennzeichen;
            sitzplätze = setSitzplätze;
        }

        public string GetKennzeichen()
        {
            return this.kennzeichen;
        }
        public double GetKilometerstand()
        {
            return this.kilometerstand;
        }

        public int GetSitzplätze()
        {
            return this.sitzplätze;
        }

        public void Fahre(int kilometer)
        {
            Console.WriteLine($"Das auto fährt {kilometer} weit.");
            this.kilometerstand = this.kilometerstand + kilometer;
        }

        public void AntenneEinfahren()
        {
            Console.WriteLine($"Die Antenne wird Eingefahren");
            this.antenne = false;
        }
        public void AntenneAusfahren()
        {
            Console.WriteLine($"Die Antenne wird Ausgefahren");
            this.antenne = true;
        }

        public bool IstAntenneDrausen()
        {
            return this.antenne;
        }

        private void VorDemWaschen()
        {
            AntenneEinfahren();
        }

        public void Waschen()
        {
            VorDemWaschen();
            Console.WriteLine("Der Wagen wird Gewaschen.");
        }

        public override string ToString()
        {
            return $"\nKennzeichen: {kennzeichen} \nKilometerstand: {kilometerstand} \nSitzplätze: {sitzplätze}\n";
        }



    }
}
