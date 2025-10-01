using AufgabenBlatt02_Aufgabe04.Modelle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt02_Aufgabe04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WiederstandNetz netz1 = new Reihenschaltung("R", 10,11,22,33,44,55,66);
        }
    }
}
