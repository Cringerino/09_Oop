using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace AufgabenBlatt01_Aufgabe05.Modele
{
    internal class Player
    {

        static Random rng = new Random();
        private int _score;
        private string _name;

        public Player(string setName)
        {
            _name = setName;
        }

        public void Gamble() 
        {
            int score = 0;
            int currentRoll;

            Console.Write($"{this._name}:");

            for(int i = 0; i < 5; i++)
            {
                currentRoll = rng.Next(1,7);
                score = score + currentRoll;
                Console.Write($"{currentRoll}, ");
            }
            Console.WriteLine("");
            this._score = score;
        }

        public int GetScore()
        {
            return this._score;
        }

    }
}
