using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirigentiDipendenti
{
    //classe padre
    internal class Lavoratore
    {
        public string nome;
        public string cognome;
        public string cf;
        public int anno_assunzione;
        public double stipendio;

        public virtual void calcolaStipendio()
        {
            Console.WriteLine("Tipo di lavoratore non definito");
        }
    }
}
