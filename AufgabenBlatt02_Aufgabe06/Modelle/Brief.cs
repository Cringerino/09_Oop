
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt02_Aufgabe06.Modelle
{
    internal class Brief: Postsendung
    {
        private int _briefTyp;

        public Brief(int setId, Adressangaben setAbsender, Adressangaben setEmpfänger) : base(setId, setAbsender, setEmpfänger)
        {
            _briefTyp = 1;
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

        public string GetBriefTyp()
        {
            if (_briefTyp == 1)
            {
                return "Standard";
            }
            else if (_briefTyp == 2)
            {
                return "Eilbrief";
            }
            else
            {
                return "Einschreiben";
            }
        }

        public override string ToString()
        {
            return $"Id: {_id,5}; Sender: {_absender.GetVorname()} {_absender.GetNachname()}; Empfänger {_empfänger.GetVorname()} {_empfänger.GetNachname()}; Brieftyp: {GetBriefTyp()}";
        }
    }
}
