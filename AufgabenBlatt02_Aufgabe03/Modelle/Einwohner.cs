using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt02_Aufgabe03.Modelle
{
    internal class Einwohner
    {
        protected int einkommen;

        public void SetzeEinkommen(int setEinkommen)
        {
            this.einkommen = setEinkommen;
        }

        public int ZuVersteuernedEinkommen()
        {
            return this.einkommen;
        }

        protected virtual void Steuer()
        {
            double steuer = 0.10;
            int zuZahlenderBetrag = (int)(this.einkommen * steuer);
            if (zuZahlenderBetrag < 1)
            {
                zuZahlenderBetrag = 1;
            }
            this.einkommen = this.einkommen - zuZahlenderBetrag;
        }
    }
}
