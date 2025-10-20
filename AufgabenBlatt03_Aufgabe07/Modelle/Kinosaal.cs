using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt03_Aufgabe07.Modelle
{
    internal class Kinosaal
    {
        protected Sitze[,] _saal { get; set; } 
        protected int freieSitzplätze { get; set; } 

        public Kinosaal() 
        {
            _saal = new Sitze[6, 10];
            freieSitzplätze = _saal.Length;
        }

        /// <summary>
        /// reserviert den sitz an der übergebenen position, wenn er frei ist.
        /// </summary>
        /// <param name="yPos"></param>
        /// <param name="xPos"></param>
        public void seatReservetion(int yPos, int xPos)
        {
            if (yPos <= _saal.GetLength(0) && xPos <= _saal.GetLength(1)) 
            { 
                if (_saal[yPos,xPos]._frei == true)
                {
                    _saal[yPos, xPos]._frei = false;
                    freieSitzplätze--;
                    Console.WriteLine($"Der Sitz aus der Reihe: {yPos} mit der Nummer {xPos} wurde Reserviert.");
                }
                else
                {
                    Console.WriteLine("Der Platz ist bereits belegt.");
                }
            }

            else
            {
                Console.WriteLine("Den sitz gibt es nicht.");
            }
        }

        public void setPrices()
        {
            for(int y = 0; y< _saal.GetLength(0);y++)
            {
                for (int x = 0; x < _saal.GetLength(1); x++)
                {
                    _saal[y, x] = new Sitze();
                    if (y <= 3)
                    {
                        if (y == 3 && (x >= 3 && x <= 6))
                        {

                            _saal[y, x]._preisklasse = 10;
                        }
                        else
                        {
                            _saal[y, x]._preisklasse = 8;
                        }
                    }
                    else
                    {
                        _saal[y, x]._preisklasse = 10;
                    }
                }
            }
        }

        public void DrawSaal()
        {
            Console.WriteLine("");
            Console.WriteLine("  \t---------------------------------------------------");
            for (int y = 0; y < _saal.GetLength(0); y++)
            {
                Console.Write($"   {y+1} \t| ");
                for (int x = 0; x < _saal.GetLength(1); x++)
                {
                    Console.Write($"{_saal[y,x]._preisklasse,2}");
                    Console.Write(" | ");
                }
                Console.WriteLine("");
                Console.WriteLine("  \t---------------------------------------------------");

            }
        }


    }
}
