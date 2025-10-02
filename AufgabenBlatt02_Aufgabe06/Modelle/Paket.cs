using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt02_Aufgabe06.Modelle
{
    internal class Paket: Postsendung
    {
        private double _gewicht;
        private bool _versichert;
        public Paket(int setId, Adressangaben setAbsender, Adressangaben setEmpfänger, int setGewicht) : base (setId, setAbsender, setEmpfänger)
        {
            _gewicht = setGewicht;
        }
        public int GetId()
        {
            return _id;
        }
        public string GetAbsender()
        {
            return $"{_absender.GetVorname()} {_absender.GetNachname()}";
        }

        public string GetEmpfänger()
        {
            return $"{_empfänger.GetVorname()} {_empfänger.GetNachname()}";
        }

        public double GetGewicht()
        {
            return _gewicht;
        }

        public override string ToString()
        {
            return $"Id: {_id,5}; Sender: {_absender.GetVorname()} {_absender.GetNachname()}; Empfänger {_empfänger.GetVorname()} {_empfänger.GetNachname()}; Gewicht: {_gewicht}";
        }
    }
}
