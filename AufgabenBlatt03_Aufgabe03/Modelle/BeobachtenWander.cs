using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenBlatt03_Aufgabe03.Modelle
{
    internal class BeobachtenWander: IBeobachten
    {
        double wasserstand;
        public void WasserStand(double setWasserstand)
        {
            wasserstand = setWasserstand;
        }

        public string checkWasser()
        {
            if (wasserstand <= 1)
            {
                return $"Der Wasserstand liegt bei {wasserstand}m, Wanderer Können den fluss überqueren.";
            }
            else if (wasserstand >= 6) 
            {
                return $"Der Wasserstand liegt bei {wasserstand}m, Wanderer können nicht wandern da der Weg überschwemmt ist.";
            }
            else
            {
                return $"Der Wasserstand liegt bei {wasserstand}m, Wanderer können ganz normal Wandern gehen.";
            }

        }

    }
}
