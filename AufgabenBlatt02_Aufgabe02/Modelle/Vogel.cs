using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt02_Aufgabe02.Modelle
{
    internal class Vogel: Haustier
    {
        protected bool singvogel;
        public Vogel(string setName, double setJahresKosten, bool setSingvogel) : base(setName, false, setJahresKosten)
        {
            singvogel = setSingvogel;
        }

        public bool GetSingvogel()
        {
            return singvogel;
        }

        public new string Beschreibung()
        {
            return $"Name: {name,8}, Steuerpflicht: " + (steuerpflicht ? "  ja" : "nein") + $", Singvogel: " +(singvogel ? "  ja" : "nein") +".";
        }
    }
}
