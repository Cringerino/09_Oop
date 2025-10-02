using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt02_Aufgabe05.Modelle
{
    internal class AktivesMitglied: Mitglied
    {
        protected int _aktivität;
        protected double _aktivitätMulti;
        protected AktivesMitglied(string setName,int setNumber, int setAktivität, double monatsBeitrag, double  setAktivitätsGrad) :base(setName, setNumber) 
        {
            if(setAktivität > 10)
            {
                setAktivität = 10;
            }
            if(setAktivität < 1)
            {
                setAktivität = 1;
            }
            _aktivität = setAktivität;
            _aktivitätMulti = setAktivitätsGrad;
            _jahresBeitrag = monatsBeitrag* 12;
            double monatlicheAusgaben = _aktivität * _aktivitätMulti;
            _jahresAusgaben = monatlicheAusgaben * 12;
        }
    }
}
