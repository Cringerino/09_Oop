using AufgabenBlatt01_Aufgabe04.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt01_Aufgabe04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PiggyBank piggy1 = new PiggyBank(20);
            int leftOverOne;
            int leftOverTen;
            int leftOverfifty;
            int leftOverEuro;
            bool isPiggyBroken;


            leftOverOne = piggy1.Add1Cent(6);
            leftOverTen = piggy1.Add10Cent(7);
            leftOverfifty = piggy1.Add50Cent(3);
            leftOverEuro = piggy1.Add1Euro(2);

            piggy1.Shake();

            isPiggyBroken = piggy1.IsBroken();
            piggy1.BreakInto();
            isPiggyBroken = piggy1.IsBroken();
        }
    }
}
