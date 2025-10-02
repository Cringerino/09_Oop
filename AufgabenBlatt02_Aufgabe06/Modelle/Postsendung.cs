using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt02_Aufgabe06.Modelle
{
    internal class Postsendung
    {
        protected int _id;
        protected Adressangaben _absender;
        protected Adressangaben _empfänger;
        protected bool _zugestellt;
        public Postsendung(int setId, Adressangaben setAbsender, Adressangaben setEmpfänger)
        {
            _id = setId;
            _absender = setAbsender;
            _empfänger = setEmpfänger;
        }

        public void Read()
        {
            Console.WriteLine($"Sender  : \nName: {_absender.GetVorname(),8} {_absender.GetNachname(),8}; Straße: {_absender.GetStraße(),12}; PLZ: {_absender.GetPlzOrt()}; Land: {_absender.GetLand()}");Console.WriteLine($"Sender: \nName: {_absender.GetVorname(),8} {_absender.GetNachname(),8}; Straße: {_absender.GetStraße(),12}; PLZ: {_absender.GetPlzOrt()}; Land: {_absender.GetLand()}");
            Console.WriteLine($"Absender: \nName: {_empfänger.GetVorname(),8} {_empfänger.GetNachname(),8}; Straße: {_empfänger.GetStraße(),12}; PLZ: {_empfänger.GetPlzOrt()}; Land: {_empfänger.GetLand()}");Console.WriteLine($"Sender: \nName: {_empfänger.GetVorname(),8} {_empfänger.GetNachname(),8}; Straße: {_empfänger.GetStraße(),12}; PLZ: {_empfänger.GetPlzOrt()}; Land: {_empfänger.GetLand()}");
        }

        public void WriteAbsender(bool abFänger, string setNachname, string setVorname, string setStraße, string setPlzOrt)
        {

            if(setStraße != "" && setPlzOrt != "")
            {
                if(abFänger)
                {
                    _absender = new Adressangaben(setNachname, setVorname, setStraße, setPlzOrt);
                }
                else if(!abFänger)
                {
                    _empfänger = new Adressangaben(setNachname, setVorname, setStraße, setPlzOrt);
                }
            }
            else
            {
                Console.WriteLine("Adresse ist ungültig");
            }
        }

        public override string ToString()
        {
            return $"Id: {_id,5}; Sender: {_absender.GetVorname()} {_absender.GetNachname()}; Empfänger {_empfänger.GetVorname()} {_empfänger.GetNachname()}";
        }

    }
}
