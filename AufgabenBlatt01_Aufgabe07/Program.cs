using AufgabenBlatt01_Aufgabe07.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt01_Aufgabe07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bruch bruch1 = new Bruch(3);
            Bruch bruch2 = new Bruch(5, 6);
            Bruch bruch3 = new Bruch(0,0);

            bruch3 = bruch1.Addiere(bruch2);
            bruch3.Ausgabe();
            bruch3 = bruch1.Subtrahiere(bruch2);
            bruch3.Ausgabe();
            bruch3 = bruch1.Multipliziere(bruch2);
            bruch3.Ausgabe();
            bruch3 = bruch1.Dividiere(bruch2);
            bruch3.Ausgabe();
        }
    }
}
