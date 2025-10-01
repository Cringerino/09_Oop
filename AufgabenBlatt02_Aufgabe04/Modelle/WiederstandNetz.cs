using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt02_Aufgabe04.Modelle
{
    internal abstract class WiederstandNetz: Wiederstand
    {
        protected List<Wiederstand> wiederstandImNetz;
        private string netzName;

        public WiederstandNetz(string setName, double wert1, double wert2, params double[] werteRest ):base("",0)
        {
            wiederstandImNetz = new List<Wiederstand>();

            Wiederstand wieder1 = new Wiederstand(setName + 1, wert1);
            wiederstandImNetz.Add( wieder1 );

            Wiederstand wieder2 = new Wiederstand(setName + 2, wert2);
            wiederstandImNetz.Add(wieder2);


            for (int i = 0; i < werteRest.Length; i++)
            {
                string nameList = setName + (i+3);
                Wiederstand wiedrTemp = new Wiederstand(nameList, werteRest[i]);
                wiederstandImNetz.Add(wiedrTemp);

            }

            foreach(Wiederstand item in wiederstandImNetz)
            {
                Console.WriteLine(item.GetWiederstandWert());
            }
        }

      /*  public WiederstandNetz(string setName, Wiederstand setWieder1, Wiederstand setWieder2, params Wiederstand[] setWiederRest) : base("",0 )
        {
            wiederstandImNetz = new List<Wiederstand>();
            wiederstandImNetz.Add(setWieder1);
            wiederstandImNetz.Add(setWieder2);
            wiederstandImNetz.AddRange(setWiederRest);
            netzName = setName;
        }*/

        public abstract void WiederstandBerechnung(List<Wiederstand> wiederList);
       
    }
}
