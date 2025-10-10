using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt03_Aufgabe03.Modelle
{
    internal class BeobachtenStraßen: IBeobachten
    {
        double wasserstand;
        bool straßenOffen = true;
        public void WasserStand(double setWasserstand)
        {
            wasserstand = setWasserstand;
        }

        public string checkWasser()
        {
            if (wasserstand >= 9)
            {
                straßenOffen = false;
                return $"Der Wasserstand liegt bei {wasserstand}m, Die Straßen sind zu, weil die Stadt überschwemmt ist.";
            }
            else  
            {

                return $"Der Wasserstand liegt bei {wasserstand}m, Die Straßen sind offen.";
            }
        }
    }
}
