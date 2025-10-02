using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt02_Aufgabe05.Modelle
{
    internal class AmateurSportler: AktivesMitglied
    {
        public AmateurSportler(string setName, int setNumber, int setAktivität): base(setName, setNumber, setAktivität, 25, 1.5)
        {

        }
    }
}
