using AufgabenBlatt01_Aufgabe02.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt01_Aufgabe02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Radio sonyRadio = new Radio();
            bool istAn;

            sonyRadio.An();
            sonyRadio.Lauter(60);
            sonyRadio.Leiser(20);
            istAn = sonyRadio.IstAn();
            sonyRadio.WähleSender(120.45);

            string radioInfo = sonyRadio.RadioInfo();
            Console.WriteLine(radioInfo);
        }
    }
}
