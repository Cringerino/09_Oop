using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt03_Aufgabe08.Modelle
{
    internal class CodeCracker
    {
        static Random rng = new Random();
        private int _correctGuesses;
        private int[] _pin;
        public int[] _code { get; }
        public int[] _saveCode { get; set; }

        public CodeCracker(int[] setCode)
        {
            _code = setCode;
        }

        public void GeneratorCode(int übereinstimmungen)
        {
            _correctGuesses = übereinstimmungen;

            saveGuesses();

            int random;
            for (int x = 0; x < this._code.Length; x++)
            {
                do
                {
                    random = rng.Next(0, 10);
                } while (this._code.Contains(random));
                this._code[x] = random;

            }

            applySave();

        }

        public void saveGuesses()
        {
            _saveCode = new int[this._code.Length];
            for(int i = 0;  i < _saveCode.Length; i++)
            {
                _saveCode[i] = this._code[i];
            }
            _pin = new int[_correctGuesses];
            int random;

            for (int x = 0; x < _pin.Length; x++)
            {
                do 
                {
                    random = rng.Next(0, this._code.Length);
                } while (_pin.Contains(random));
                _pin[x] = random;
            }

        }

        private void applySave()
        {
            foreach (int item in _pin)
            {
                this._code[item] = _saveCode[item];
            }
        }

    }
}
