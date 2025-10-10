using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AufgabenBlatt03_Aufgabe01.Modelle
{
    internal class Vermitler: INachrichtenQuelle, INachrichtenEmpfänger
    {
        private bool _angemeldet = false;
        public void EmpfangeNachricht(string nachricht)
        {
        Console.WriteLine($"Es wurde folgende nachricht erhalten: \n{nachricht}");
        }

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
            Console.WriteLine("Der Vermitler hier");
        }
    }
}
