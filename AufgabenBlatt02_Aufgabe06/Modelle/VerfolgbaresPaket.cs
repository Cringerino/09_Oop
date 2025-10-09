using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt02_Aufgabe06.Modelle
{
    internal class VerfolgbaresPaket: Paket
    {
        protected List<Station> _stations;

        public VerfolgbaresPaket(int setId, Adressangaben setAbsender, Adressangaben setEmpfänger, int setGewicht) : base( setId, setAbsender, setEmpfänger, setGewicht)
        {
            _stations = new List<Station>();
            SetzeStation(setAbsender);
        }

        public void SetzeStation(Adressangaben neueStation)
        {
            Station absender = new Station(neueStation);
            _stations.Add(absender);
        }
    }
}
