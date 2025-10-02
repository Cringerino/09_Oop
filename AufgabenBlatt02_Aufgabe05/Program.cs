using AufgabenBlatt02_Aufgabe05.Modelle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt02_Aufgabe05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Verein verein1 = new Verein("Nightingale", 10);
            Mitglied mitglied1 = new AmateurSportler("Jason",0001, 2);
            Mitglied mitglied2 = new Trainer("Jürgen", 0002, 5);
            Mitglied mitglied3 = new Vorstandsmitglied("Dieter", 0003,8);
            Mitglied mitglied4 = new SpitzenSportler("Josef", 0004, 8);
            Mitglied mitglied5 = new Vorstandsmitglied("Miguel", 0005, 14);
            Mitglied mitglied6 = new AmateurSportler("Peter", 0006, 4);
            Mitglied mitglied7 = new AmateurSportler("Sahra", 0007, 5);
            Mitglied mitglied8 = new SpitzenSportler("Anna", 0008, 0);
            Mitglied mitglied9 = new AmateurSportler("Linus", 0009, 8);
            Mitglied mitglied10 = new AmateurSportler("Daniel", 0010, 7);
            Mitglied mitglied11 = new AmateurSportler("Max", 0011, 6);


            verein1.MitgliedHinzufügen(mitglied1);
            verein1.MitgliedHinzufügen(mitglied2);
            verein1.MitgliedHinzufügen(mitglied3);
            verein1.MitgliedHinzufügen(mitglied4);
            verein1.MitgliedHinzufügen(mitglied5);
            verein1.MitgliedHinzufügen(mitglied6);
            verein1.MitgliedHinzufügen(mitglied7);
            verein1.MitgliedHinzufügen(mitglied8);
            verein1.MitgliedHinzufügen(mitglied9);
            verein1.MitgliedHinzufügen(mitglied10);
            verein1.MitgliedHinzufügen(mitglied11);

            verein1.Ausgabe(verein1);
        }
    }
}
