using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt02_Aufgabe05.Modelle
{
    internal class Vorstandsmitglied: Mitglied
    {
        protected int _kompetenzwert;
        public Vorstandsmitglied(string setName, int setNumber, int setKompetenzwert) : base(setName, setNumber)
        {
            if (setKompetenzwert > 10)
            {
                setKompetenzwert = 10;
            }
            if (setKompetenzwert < 1)
            {
                setKompetenzwert = 1;
            }
            _kompetenzwert = setKompetenzwert;
            _jahresBeitrag = _kompetenzwert * 100;
            _jahresAusgaben = _jahresBeitrag * 0.20;
        }
    }
}
