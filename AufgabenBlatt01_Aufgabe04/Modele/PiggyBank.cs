using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt01_Aufgabe04.Modele
{
    internal class PiggyBank
    {
        private int[] _Coins = new int[4];
        private int _maxAmount;
        private int _currentAmount;
        private bool _Bonked;

        public PiggyBank(int maxAmount)
        {
            _maxAmount = maxAmount;
            _Bonked = false;
            _currentAmount = 0;
        }

        public void Shake()
        {
            string coinCount = "";

            if (this._currentAmount == 0)
            {
                Console.WriteLine("Die Spaar Dose ist leer");
            }
            else
            {
                if (this._currentAmount < this._maxAmount / 3)
                {
                    coinCount = "zu ca einem drittel";
                }
                else if (this._currentAmount < this._maxAmount / 2)
                {
                    coinCount = "zu ca hälfe";
                }
                else if (this._currentAmount < 2 * (this._maxAmount / 3))
                {
                    coinCount = "zu ca zwei drittel";
                }
                else if (this._currentAmount <= this._maxAmount)
                {
                    coinCount = "ganz";
                }
                Console.WriteLine($"Es hört sich an als ob die Spaardose {coinCount} voll ist");
            }

        }

        public bool IsBroken()
        {
            if (this._Bonked)
            {
                Console.WriteLine("Die Spaardose ist offen");
                return this._Bonked;
            }
            else
            {
                Console.WriteLine("Die Spaardose ist nicht offen");
                return this._Bonked;
            }

        }

        public void BreakInto()
        {
            this._Bonked = true;
            int savedMoney;
            savedMoney = this._Coins[0] + (this._Coins[1] * 10) + (this._Coins[2] * 50) + (this._Coins[3] * 100);

            for(int i = 0; i< this._Coins.Length; i++)
            {
                this._Coins[i] = 0;
            }

            Console.WriteLine($"in der Dose befand sich {savedMoney}cent");

        }

        public int Add1Cent(int münzenAnzahl)
        {
            int münzenCounter = münzenAnzahl;
            for (int i = 0; i < münzenAnzahl; i++)
            {
                if(this._currentAmount < this._maxAmount)
                {
                    this._Coins[0]++;
                    this._currentAmount++;
                    münzenCounter--;
                }
                else
                {
                    break;
                }
            }
            return münzenAnzahl;
        }
        public int Add10Cent(int münzenAnzahl)
        {

            int münzenCounter = münzenAnzahl;
            for (int i = 0; i < münzenAnzahl; i++)
            {
                if (this._currentAmount < this._maxAmount)
                {
                    this._Coins[1]++;
                    this._currentAmount++;
                    münzenCounter--;
                }
                else
                {
                    break;
                }
            }
            return münzenAnzahl;
        }
        public int Add50Cent(int münzenAnzahl)
        {
            int münzenCounter = münzenAnzahl;
            for (int i = 0; i < münzenAnzahl; i++)
            {
                if (this._currentAmount < this._maxAmount)
                {
                    this._Coins[2]++;
                    this._currentAmount++;
                    münzenCounter--;
                }
                else
                {
                    break;
                }
            }
            return münzenAnzahl;
        }
        public int Add1Euro(int münzenAnzahl)
        {
            int münzenCounter = münzenAnzahl;
            for (int i = 0; i < münzenAnzahl; i++)
            {
                if (this._currentAmount < this._maxAmount)
                {
                    this._Coins[3]++;
                    this._currentAmount++;
                    münzenCounter--;
                }
                else
                {
                    break;
                }
            }
            return münzenAnzahl;
        }
    }
}
