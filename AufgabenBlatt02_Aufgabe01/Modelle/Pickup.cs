using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt02_Aufgabe01.Modelle
{
    internal class Pickup : Auto
    {
        private int maxLoad;
        private int currentLoad;
        public Pickup(string setKennzeichen, int setMaxLoad) :base(setKennzeichen,2) 
        {
            kennzeichen = setKennzeichen;
            currentLoad = 0;
            maxLoad = setMaxLoad;
        }  

        public bool Beladen(int ladungsMenge)
        {
            if (ladungsMenge + this.currentLoad <= this.maxLoad)
            {
                this.currentLoad = currentLoad + ladungsMenge;
                Console.WriteLine("Pickup wurde Beladen");
                return true;
            }
            else
            {
                Console.WriteLine("Ladungs is zu groß.");
                return false;
            }
        }

        public bool Entladen(int ladungsMenge)
        {
            if (ladungsMenge <= currentLoad)
            {
                currentLoad = currentLoad - ladungsMenge;
                Console.WriteLine("Pickup wurde Entladen");
                return true;
            }
            else
            {
                Console.WriteLine("Soviel ladung befindet sich nicht auf dem Pickup");
                return false;
            }
        }

        private void VorDemWaschen()
        {
            AntenneEinfahren();
            Entladen(this.currentLoad);
        }

        public int GetLadung()
        {
            return this.currentLoad;
        }

        public override string ToString() 
        {
            return $"\nKennzeichen: {kennzeichen} \nKilometerstand: {kilometerstand} \nSitzplätze: {sitzplätze} \nLade Kapazitäten: {maxLoad} \nAktuelle Ladungsgröße: {currentLoad} \n";

        }
    }
}
