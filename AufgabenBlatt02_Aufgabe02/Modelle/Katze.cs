using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt02_Aufgabe02.Modelle
{
    internal class Katze: Haustier
    {
        protected Vogel lieblingsVogel;
        

        public Katze(string setName, double setJahresKosten, Vogel setLieblingsVogel) :base(setName, false, setJahresKosten) 
        { 
            lieblingsVogel = setLieblingsVogel;
        }

        public void Vogel()
        {
            Console.WriteLine($"Der Name des Lielings Vogel ist: {lieblingsVogel.GetName()}");
        }

        public new string Beschreibung()
        {
            return $"Name: {name,8}, Steuerpflicht: " + (steuerpflicht? "  ja" : "nein") + $", lieblingsVogel: "+(lieblingsVogel==null?"kein Vogel":lieblingsVogel.GetName())+".";
        }

        public void LieblingsVogel(Vogel NeuerVogel)
        {
            this.lieblingsVogel = NeuerVogel;
        }
    }
}
