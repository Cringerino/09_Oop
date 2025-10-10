using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt03_Aufgabe02.modelle
{
    internal class Temperatur: Fahrenheit, Celsius, Kelvin
    {
        private double baseTemp;
        public double Kelvin { get { return baseTemp + 273.15; } set { baseTemp = value - 273.15; } }
        public double Fahrenheit { get { return (baseTemp*9)/5+32; } set { baseTemp = (value-32)*5/9; } }
        public double Celsius { get {return baseTemp; } set { baseTemp = value; } }

        public override string ToString()
        {


            return $"{this.baseTemp}";
        }
    }
}
