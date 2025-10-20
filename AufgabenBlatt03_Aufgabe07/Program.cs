using AufgabenBlatt03_Aufgabe07.Modelle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt03_Aufgabe07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kinosaal kino1 = new Kinosaal();
            kino1.setPrices();
            kino1.DrawSaal();
        }
    }
}
