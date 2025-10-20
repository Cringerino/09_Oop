using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt03_Aufgabe08.Modelle
{
    internal class CodeTester
    {
        private int[] _code { get; }
        private CodeCracker cc;
        private int _range;
        private int[] saveCode;
        private int _attempts;
        protected int[] targetCode { get; set; } = new int[] { 3, 5, 6, 1 } ;
        public CodeTester(int setRange)
        {
            _range = setRange;
            _code = new int[_range];
            cc = new CodeCracker(this._code);
            TestCode();
        }

        public void TestCode()
        {
            int correctGuesses = 0;
            do {
                for (int x = 0; x < cc._code.Length; x++)
                {
                    if (cc._code[x] == targetCode[x])
                    {
                        correctGuesses++;
                        _attempts++;
                    }
                }

                if(correctGuesses != _range)
                {
                    cc.GeneratorCode(correctGuesses);
                    correctGuesses = 0;
                }

               
            } while (correctGuesses < _range);
            Console.WriteLine($"{cc._code[0]}, {cc._code[1]}, {cc._code[2]}, {cc._code[3] }");
            Console.WriteLine($"Versuche: {_attempts}");
        }

      
    }


}
