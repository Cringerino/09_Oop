using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt03_Aufgabe06.Modelle
{ 
    internal class Schüler
    {
        protected int _id;
        protected string _name;
        protected List<Projekt> _aktivitäten;

        public Schüler(int setId, string setName) 
        { 
            _id = setId;
            _name = setName;
            _aktivitäten = new List<Projekt>();
        }

        public void AddActivity(Projekt neueAktivität)
        {
            _aktivitäten.Add(neueAktivität);
        }

        public int GetId()
        {
            return _id;
        }
    }
}
