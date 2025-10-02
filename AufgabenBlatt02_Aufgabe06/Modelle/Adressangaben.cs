using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt02_Aufgabe06.Modelle
{
    internal class Adressangaben
    {
        protected string _nachname;
        protected string _vorname;
        protected string _straße;
        protected string _plzOrt;
        protected string _land;
        public Adressangaben(string setNachname, string setVorname, string setStraße, string setPlzOrt)
        {
            _nachname = setNachname;
            _vorname = setVorname;
            _straße = setStraße;
            _plzOrt = setPlzOrt;
            _land = "Deutschland";
        }

        public bool IsGültig()
        {
            if (_nachname == "" || _vorname == "" || _straße == "" || _plzOrt == "")
            {
                return false;
            }
            return true;
        }


        public string GetNachname()
        {
            return _nachname;
        }
        public string GetVorname()
        {
            return _vorname;
        }

        public string GetStraße()
        {
            return _straße;
        }

        public string GetPlzOrt()
        {
            return _plzOrt;
        }

        public string GetLand()
        {
            return _land; 
        }
        public override string ToString()
        {
            return $"Vorname: {_vorname,8}; Nachname: {_nachname}; Straße: {_straße}, PLZ: {_plzOrt}";
        }


    }
}
