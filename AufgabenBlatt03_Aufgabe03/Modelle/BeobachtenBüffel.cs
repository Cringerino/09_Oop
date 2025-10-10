using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt03_Aufgabe03.Modelle
{
    internal class BeobachtenBüffel: IBeobachten
    {
        double wasserstand;
        public void WasserStand(double setWasserstand)
        {
            wasserstand = setWasserstand;
        }

        public string checkWasser()
        {
            if (wasserstand >= 5 && wasserstand < 7)
            {
                return $"Der Wasserstand liegt bei {wasserstand}m, die Büffel sollten von dem Fluss entfernt werden";
            }
            else if (wasserstand >= 7)
            {
                return $"Der Wasserstand liegt bei {wasserstand}m, die Büffel müssen jetzt sofortvon dem Fluss entfernt werden";

            }
            else if (wasserstand <= 0.3) 
            {
                return $"Der Wasserstand liegt bei {wasserstand}m, die Büffel brauchen weiteres Wasser.";
            }
            else
            {
                return $"Der Wasserstand liegt bei {wasserstand}m, die Büffel fühlen sich wohl <3.";
            }
        }
    }

}
