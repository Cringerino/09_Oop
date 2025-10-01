using AufgabenBlatt02_Aufgabe01.Modelle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt02_Aufgabe01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Pickup pickup1 = new Pickup("DU-WU 4", 10);
            Pickup pickup2 = new Pickup("DO-WO 4", 15);
            Pickup pickup3 = new Pickup("DM-WM 4", 20);

            Auto auto1 = new Auto("EU-WU 4", 5);
            Auto auto2 = new Auto("EO-WO 4", 5);
            Auto auto3 = new Auto("EM-WM 4", 5);

            pickup1.Beladen(5);
            pickup2.Beladen(14);
            pickup3.Beladen(17);

            pickup1.Fahre(50);
            pickup2.Fahre(20);
            pickup3.Fahre(100);

            auto1.Fahre(10);
            auto2.Fahre(120);
            auto3.Fahre(70);

            pickup1.Waschen();
            pickup2.Waschen();
            pickup3.Waschen();

            auto1.Waschen();
            auto2.Waschen();
            auto3.Waschen();

            Console.WriteLine(pickup1.ToString());
            Console.WriteLine(pickup2.ToString());
            Console.WriteLine(pickup3.ToString());

            Console.WriteLine(auto1.ToString());
            Console.WriteLine(auto2.ToString());
            Console.WriteLine(auto3.ToString());

        }                          
    }
}
