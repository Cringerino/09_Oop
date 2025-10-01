using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt01_Aufgabe03.Modele
{
    internal class Filiale
    {
        private string _name;
        private int _inventroy;
        private int _till;

        public Filiale(string setName, int setInventroy, int setTill)
        {
            _name = setName; 
            _inventroy = setInventroy;
            _till = setTill;
            
        }
        public void Buy()
        {
            if (_till >= 10)
            {
                this._till = this._till - 10;
                this._inventroy++;
            }
        }

        public void Sell()
        {
            if (_inventroy >= 1)
            {
                this._till = this._till + 20;
                this._inventroy--;
            }
        }

        public void Output()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"Die Filiale {this._name}, hat ein Warenbestand von: {this._inventroy} und eine Kasse von: {this._till}\u20AC");
        }
    }
}
