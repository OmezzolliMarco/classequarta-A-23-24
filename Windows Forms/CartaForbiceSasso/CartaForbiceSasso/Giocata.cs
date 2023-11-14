using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartaForbiceSasso
{
    internal class Giocata
    {
        public string g1;
        public string g2;

        //booleano per stabilire chi ha vinto: se vero ha vinto g1, alrimenti 
        // ha vinto g2
        public bool vincita;

        public Giocata(string g1, string g2, bool vincita)
        {
            this.g1 = g1;
            this.g2 = g2;
            this.vincita = vincita;
        }

        public string toString()
        {
            if (this.vincita)
            {
                //vinto il primo giocatore
                return "Ha vinto: " + this.g1;
            }
            else
            {
                //vinto secondo giocatore
                return "Ha vinto: " + this.g2;
            }
        }
    }
}
