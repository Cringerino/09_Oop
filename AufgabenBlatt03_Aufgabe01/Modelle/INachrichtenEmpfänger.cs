using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt03_Aufgabe01.Modelle
{
    internal interface INachrichtenEmpfänger
    {
        void EmpfangeNachricht(string nachricht);

    }
}
