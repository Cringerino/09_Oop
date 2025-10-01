using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt02_Aufgabe03.Modelle
{
    internal class Adel: Einwohner
    {
        protected override void Steuer()
        {
            double steuer = 0.10;
            int zuZahlenderBetrag = (int)(this.einkommen * steuer);
            if (zuZahlenderBetrag < 20)
            {
                zuZahlenderBetrag = 20;
            }

            this.einkommen = this.einkommen - zuZahlenderBetrag;
        }
    }
}
