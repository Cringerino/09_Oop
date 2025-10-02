using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt02_Aufgabe05.Modelle
{
    internal class Mitglied
    {
        protected string _name;
        protected int _number;
        protected double _jahresBeitrag;
        protected double _jahresAusgaben;
        public Mitglied(string setName, int setNumber) 
        { 
            _name = setName;
            _number = setNumber;
        }


        public virtual double GetEinnahmen()
        {
            return _jahresBeitrag;
        }

        public virtual double GetAusgaben()
        {
            return _jahresAusgaben;
        }

        public double GetÜberschuss()
        {
            double überschuss;
            überschuss = _jahresBeitrag - _jahresAusgaben;
            return überschuss;
        }

        public virtual void Ausgabe(Verein ausgabeVerein)
        {
            Console.WriteLine($"Verein: {_name}");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine($"|{"Name",-20} | {"ID",-5} | {"Einnahmen",-12} | {"Ausgaben",-12} | {"Überschuss",-12} |");
            Console.WriteLine("----------------------------------------------------------------------------");
            foreach (Mitglied item in ausgabeVerein.GetMitglieder())
            {
                Console.WriteLine($"|{item._name,-20} | {item._number,-5} | {item.GetEinnahmen(),-12} | {item.GetAusgaben(),-12} | {item.GetÜberschuss(),-12} |");
                Console.WriteLine("----------------------------------------------------------------------------");
            }
        }

    }
}
