using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AufgabenBlatt02_Aufgabe02.Modelle
{
    internal class Hund: Haustier
    {
        private string rasse;
        public Hund(string setName, double setJahresKosten, string setRasse) :base(setName, true, setJahresKosten) 
        { 
            rasse = setRasse;
        }

        public string GetRasse()
        {
            return rasse; 
        }

        public new string Beschreibung()
        {
            return $"Name: {name,8}, Steuerpflicht: " + (steuerpflicht ? "  ja" : "nein") + $", Rasse: {rasse,10}.";
        }
    }
}
