using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt03_Aufgabe03.Modelle
{
    internal interface IBeobachten
    {
        void WasserStand(double neuerWasserstand);

        string checkWasser();
    }
}
