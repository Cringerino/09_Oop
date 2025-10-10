using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt03_Aufgabe01.Modelle
{
    internal class Zeitung: INachrichtenQuelle
    {

        bool _angemeldet;
        public void Anmelden(INachrichtenEmpfänger empfänger)
        {
            _angemeldet = true;
        }

        public void Abmelden(INachrichtenEmpfänger empfänger)
        {
            _angemeldet = false;
        }

        public void SendeNachricht(string nachricht)
        {
            Console.WriteLine("Zeitung hier");
        }
    }
}
