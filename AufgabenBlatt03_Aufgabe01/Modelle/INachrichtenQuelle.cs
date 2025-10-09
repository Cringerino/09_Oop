using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt03_Aufgabe01.Modelle
{
    internal interface INachrichtenQuelle
    {
        void Anmelden(INachrichtenEmpfänger empfänger);
        // Angemeldete können sich bei der Quelle wieder abmelden
        // (falls sie angemeldet sind)
        void Abmelden(INachrichtenEmpfänger empfänger);
        // neue Nachricht wird an alle angemeldeten Empfänger übergeben
        // (Aufruf deren Methode EmpfangeNachricht)
        void SendeNachricht(string nachricht);
    }
}
