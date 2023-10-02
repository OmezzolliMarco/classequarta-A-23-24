using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirigentiDipendenti
{
    //la classe impiegato eredita i suoi attributi da Lavoratore
    internal class Impiegato:Lavoratore
    {
        public Dirigente dirigente;
        public override void calcolaStipendio()
        {
            double stip = this.stipendio - (this.stipendio * 0.15);
            Console.WriteLine(stip);
        }
    }
}
