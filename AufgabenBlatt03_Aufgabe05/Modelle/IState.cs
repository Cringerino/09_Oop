using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt03_Aufgabe05.Modelle
{
    internal interface IState
    {
        void GotMushroom();
        void GotFireFlower();
        void GotFeather();
        void MetMonster();
    }
}
