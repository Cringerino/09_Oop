using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt02_Aufgabe02.Modelle
{
    internal class Haustier
    {
        protected string name;
        protected bool steuerpflicht;
        protected double jahreskostenTierarzt;

        public Haustier(string setName, bool setSteuerpflicht, double setJahreskosten) 
        { 
            name = setName;
            steuerpflicht = setSteuerpflicht;
            jahreskostenTierarzt = setJahreskosten;
        }

        public string GetName()
        {
            return name;
        }
        public bool GetSteuerpflicht()
        {
            return steuerpflicht;
        }
        public double GetKosten()
        {
            return jahreskostenTierarzt;
        }

        public virtual string Beschreibung()
        {
            return $"Name: {name}, Steuerpflicht: " +( steuerpflicht? "ja":"nein" )+".";
        }

    }
}
