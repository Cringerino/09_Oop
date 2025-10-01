using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt01_Aufgabe07.Modele
{
    internal class Bruch
    {
        private int zähler;
        private int nenner;
        public Bruch(int setZähler)
        {
            zähler = setZähler;
            nenner = 1;

        }
        public Bruch(int setZähler, int setNenner)
        {
            zähler = setZähler;
            nenner = setNenner;
        }

        public void Ausgabe()
        {
            Console.WriteLine($"{this.zähler}/{this.nenner}");
        }

        public void Kehrwert()
        {
            int temp;
            temp = this.nenner;
            this.nenner = this.zähler;
            this.zähler = temp;
        }

        public void Kürzen()
        {
            int tempZähler = this.zähler;
            int tempNenner = this.nenner;
            while (tempNenner != 0)
            {
                int temp = tempNenner;
                tempNenner = tempZähler % tempNenner;
                tempZähler = temp;
            }
            Math.Abs(tempZähler);
            this.zähler = this.zähler / tempZähler;
            this.nenner = this.nenner / tempZähler;
        }

        public Bruch Addiere(Bruch bruch2)
        {
            Bruch bruch3 = new Bruch(0, 0);

            bruch3.zähler = (this.zähler * bruch2.nenner) + (bruch2.zähler * this.nenner);
            bruch3.nenner = this.nenner * bruch2.nenner;

            bruch3.Kürzen();

            return bruch3;
        }
        public Bruch Subtrahiere(Bruch bruch2)
        {
            Bruch bruch3 = new Bruch(0, 0);

            bruch3.zähler = (this.zähler * bruch2.nenner) - (bruch2.zähler * this.nenner);
            bruch3.nenner = this.nenner * bruch2.nenner;

            bruch3.Kürzen();

            return bruch3;

        }
        public Bruch Multipliziere(Bruch bruch2)
        {
            Bruch bruch3 = new Bruch(0, 0);

            bruch3.zähler = this.zähler * bruch2.zähler;
            bruch3.nenner = this.nenner * bruch2.nenner;

            bruch3.Kürzen();

            return bruch3;

        }
        public Bruch Dividiere(Bruch bruch2)
        {
            Bruch bruch3 = new Bruch(0, 0);

            bruch2.Kehrwert();

            bruch3.zähler = this.zähler * bruch2.zähler;
            bruch3.nenner = this.nenner * bruch2.nenner;

            bruch3.Kürzen();

            return bruch3;

        }
    }
}
