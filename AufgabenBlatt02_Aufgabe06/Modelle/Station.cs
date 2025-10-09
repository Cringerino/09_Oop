using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt02_Aufgabe06.Modelle
{
    internal class Station
    {
        protected Adressangaben _place;
        protected System.DateTime _dateTime;

        public Station(Adressangaben setPlace)
        {
            _place = setPlace;
            _dateTime = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Ort: {_place}; Zeitstempel: {_dateTime}";
        }
    }
}
