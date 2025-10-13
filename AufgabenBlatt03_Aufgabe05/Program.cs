using AufgabenBlatt03_Aufgabe05.Modelle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt03_Aufgabe05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mario luigi = new Mario();

            luigi.GetShroom();
            luigi.TakeDmg();
            luigi.GetFireFlower();
            Console.WriteLine(luigi.GetCoins());
            luigi.GetShroom();
            luigi.GetShroom();
            luigi.GetFeather();
            luigi.GetFeather();
            Console.WriteLine(luigi.ToString());


        }
    }
}
