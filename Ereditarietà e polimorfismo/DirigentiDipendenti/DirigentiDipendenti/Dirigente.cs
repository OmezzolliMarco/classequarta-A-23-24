using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirigentiDipendenti
{
    //la classe dirigente eredita dalla classe lavoratore
    internal class Dirigente : Lavoratore
    {
        private int livelloAutorizzazione;

        public override void calcolaStipendio()
        {
            double stip = this.stipendio - (this.stipendio * 0.26);
            Console.WriteLine(stip);
        }
    }
}
