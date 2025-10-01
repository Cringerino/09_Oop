using AufgabenBlatt01_Aufgabe05.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt01_Aufgabe05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Cringerino");
            Player player2 = new Player("Busherino");

            player1.Gamble();
            player2.Gamble();

            if (player1.GetScore() < player2.GetScore())
            {
                Console.WriteLine("Spieler Zwei hat gewonnen");
            }
            else if (player1.GetScore() > player2.GetScore())
            {
                Console.WriteLine("Spieler Eins hat gewonnen");
            }
            else if(player1.GetScore() == player2.GetScore())
            {
                Console.WriteLine("Gleichstand");
            }
        }
    }
}
