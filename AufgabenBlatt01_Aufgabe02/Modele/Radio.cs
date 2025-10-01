using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt01_Aufgabe02.Modele
{
    internal class Radio
    {
        private bool eingeschaltet;
        private int lautstärke;
        private double frequenz;

        public Radio()
        {
            eingeschaltet = false;
            lautstärke = 0;
            frequenz = 0;
        }

        public void Lauter(int umValueErhöhen)
        {
            this.lautstärke = this.lautstärke + umValueErhöhen;
            if(this.lautstärke >= 100)
            {
                this.lautstärke = 100;
            }
        }
        public void Leiser(int umValueErhöhen)
        {
            lautstärke = lautstärke - umValueErhöhen;
            if (this.lautstärke <= 0)
            {
                this.lautstärke = 0;
            }
        }

        public void An()
        {
            this.eingeschaltet = true;
        }

        public void Aus()
        {
            this.eingeschaltet = false;
        }

        public bool IstAn()
        {
            return this.eingeschaltet;
        }

        public void WähleSender(double neueFrequenz)
        {
            this.frequenz = neueFrequenz;
        }

        public string RadioInfo()
        {
            return "Radio " + (this.eingeschaltet ? "an" : "aus") +  $": Frequenz={this.frequenz}; Lautstärke={this.lautstärke}";
        }
    }
}
