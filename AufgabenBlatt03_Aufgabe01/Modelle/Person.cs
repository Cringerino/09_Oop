using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt03_Aufgabe01.Modelle
{
    internal class Person: INachrichtenEmpfänger
    {
        public string _name;

        public string Name { get { return _name; } set { _name = value ; } }

        public void EmpfangeNachricht(string nachricht)
        {
            Console.WriteLine($"{_name} hat folgende nachricht erhalten: \n{nachricht}");
        }
    }
}
