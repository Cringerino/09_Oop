using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt02_Aufgabe05.Modelle
{
    internal class SpitzenSportler: AktivesMitglied
    {
        public SpitzenSportler(string setName,int setNumber, int setAktivität) : base(setName, setNumber, setAktivität, 10, 5)
        { 

        }
    }
}
