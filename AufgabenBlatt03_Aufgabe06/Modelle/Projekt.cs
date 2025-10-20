using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt03_Aufgabe06.Modelle
{
    internal class Projekt
    {
        protected char _id;
        protected string _projektname;
        protected List<Schüler> _teilnehmer;

        public Projekt(char setId, string projektname, List<Schüler> teilnehmer)
        {
            _id = setId;
            _projektname = projektname;
            _teilnehmer = teilnehmer;
        }

        public int TeilnehmerAnzahl()
        {
            return _teilnehmer.Count;
        }
        
    }
}
