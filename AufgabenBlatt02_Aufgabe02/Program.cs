using AufgabenBlatt02_Aufgabe02.Modelle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AufgabenBlatt02_Aufgabe02
{
    internal class Program
    {
        static Haustier[] haustiere = new Haustier[6];
        static void Main(string[] args)
        {
            
            Anlegen(haustiere);
            NeuerLieblingsVogel((Katze)haustiere[4]);
            Ausgeben();
            

        }

        static void Anlegen(Haustier[] haustiere)
        {
            haustiere[0] = new Hund("Rex", 2000, "Bulldogge");
            haustiere[1] = new Hund("Josha", 4000, "Labrador Shepherd");
            haustiere[2] = new Vogel("tweety", 20, true);
            haustiere[3] = new Vogel("Raven", 20, false);
            haustiere[4] = new Katze("Momo", 200, null);
            haustiere[5] = new Katze("Peach", 0, null);
        }

        static void NeuerLieblingsVogel( Katze meinungsänderung)
        {
            int zähler = 0;
            for(;zähler < haustiere.Length; zähler++)
            {
                if (haustiere[zähler] is Vogel)
                {
                    break;
                }
            }
            meinungsänderung.LieblingsVogel((Vogel)haustiere[zähler]);
        }

        static void Ausgeben()
        {
            double rechnung = 0;
            foreach(Haustier element in haustiere)
            {
                if(element is Hund)
                {
                    Hund hundTemp = element as Hund;
                    Console.WriteLine($"Es ist der Hund \n {hundTemp.Beschreibung()}\n");
                }
                if(element is Katze)
                {
                    Katze katzeTemp = element as Katze;
                    Console.WriteLine($"Es ist die Katze \n {katzeTemp.Beschreibung()}\n");
                }
                if (element is Vogel)
                {
                    Vogel vogelTemp = element as Vogel;
                    Console.WriteLine($"Es ist der Vogel \n {vogelTemp.Beschreibung()}\n");
                }
                rechnung = rechnung + element.GetKosten();
            }

            Console.WriteLine($"Die insgesamt kosten betragen: {rechnung}");

        }
    }
}
