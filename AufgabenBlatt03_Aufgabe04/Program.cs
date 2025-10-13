using AufgabenBlatt03_Aufgabe04.Modelle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt03_Aufgabe04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ninja shinobi = new Ninja(2);
            Ninja Orochi = new Ninja(1);

            shinobi.Angriff("den Samurai");
            Orochi.Angriff("den Kensei");
        }
    }
}
