using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt02_Aufgabe03.Modelle
{
    internal class Leibeigene: Einwohner
    {
        protected override void Steuer()
        {
            double steuer = 0.10;
            int freiBetrag = 12; 
            int zuZahlenderBetrag = 1;
            if (this.einkommen > 12)
            {
               zuZahlenderBetrag  = (int)((this.einkommen - freiBetrag) * steuer);
                if (zuZahlenderBetrag < 1)
                {
                    zuZahlenderBetrag = 1;
                }
            }

            this.einkommen = this.einkommen - zuZahlenderBetrag;
        }
    }
}
