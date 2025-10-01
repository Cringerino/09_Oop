using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt01_Aufgabe06.Modele
{
    internal class Prüfsumme
    {
        private string _inputIdNummer;
        private int[] _idNummerReverse;

        public Prüfsumme(string setIdNummer)
        {
            _inputIdNummer = setIdNummer;
        }

        public void Combined()
        {
            int inputId;
            inputId = SafeInput();
            ReverseIdNum(inputId);
            Calculator();
        }

        private int SafeInput() 
        {
            int inputId;
            string[] cleanNumArray = this._inputIdNummer.Split('-');
            string cleanNum = "";

            for (int i = 0; i < cleanNumArray.Length; i++)
            {
                cleanNum = cleanNum + cleanNumArray[i];
            }

            int.TryParse(cleanNum, out inputId);
            return inputId;
        }

        private void ReverseIdNum(int inputId)
        {
            this._idNummerReverse = new int[9];

            for (int i = 0; i < 9; i++)
            {
                this._idNummerReverse[i] = inputId % 10;
                inputId = inputId / 10;
            }
        }

        private void Calculator()
        {
            int controlle;
            int sum = 0;
            int finalCalc = 0;
            for(int i = 1; i < this._idNummerReverse.Length; i = i+2)
            {
                controlle = this._idNummerReverse[i]*2;
                if(controlle >= 10)
                {
                    int[] quersumme = new int[2];
                    for(int j = 0; j < 2; j++)
                    {
                        quersumme[j] = controlle % 10;
                        controlle = controlle / 10;
                        sum = sum + quersumme[j];
                    }
                    this._idNummerReverse[i] = sum;
                }
                
            }

            for (int i = 0; i < this._idNummerReverse.Length; ++i)
            {
                finalCalc = finalCalc + this._idNummerReverse[i];
            }

            Console.WriteLine(finalCalc);
        }

    }

}
