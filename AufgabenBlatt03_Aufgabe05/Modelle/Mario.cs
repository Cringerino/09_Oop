using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AufgabenBlatt03_Aufgabe05.Modelle
{
    internal class Mario
    {
        protected IState state = new SmallMario();
        protected int lifeCount = 3;
        protected int coinCount;

        public string GetState()
        {
            if (state is FireMario)
            {
                return "Feuer Mario";
            }
            else if (state is CapeMario)
            {
                return "Cape Mario";

            }
            else if (state is SuperMario)
            {
                return "Super Mario";
            }
            else if (state is SmallMario)
            {
                return "Small Mario";
            }
            else 
            { 
                return null;
            }
        }

        public string GetCoins()
        {
            return $"Coins: {coinCount,4}";
        }

        public void AddCoins(int addCoins)
        {
            coinCount = coinCount + addCoins;
            if (coinCount >= 1000)
            {
                lifeCount++;
                coinCount = coinCount - 1000;
            }
        }

        public void GetShroom()
        {
            if (state is SmallMario)
            {
                state = new SuperMario();
            }
            AddCoins(100);
        }

        public void GetFireFlower()
        {
            if (state is SmallMario || state is SuperMario || state is CapeMario)
            {
                state = new FireMario();
            }
            AddCoins(200);
        }

        public void GetFeather()
        {
            if (state is SmallMario || state is SuperMario || state is FireMario)
            {
                state = new CapeMario();
            }
            AddCoins(300);
        }

        public void TakeDmg()
        {
            if (state is CapeMario || state is FireMario )
            {
                state = new SuperMario();
            }
            else if(state is SuperMario) 
            {
                state = new SmallMario();
            }
            else if (state is SmallMario)
            {
                lifeCount = lifeCount - 1;
                if (lifeCount <= 0)
                {
                    CloseGame();
                }
            }
        }

        public void CloseGame()
        {
            Console.Clear();
            Console.WriteLine("Spiel vorbei");
            Console.ReadKey();
            Environment.Exit(0);
        }

        public override string ToString()
        {
            return $"Leben: {lifeCount}| Coins: {GetCoins()}| State: {GetState()}";
        }
    }
}
