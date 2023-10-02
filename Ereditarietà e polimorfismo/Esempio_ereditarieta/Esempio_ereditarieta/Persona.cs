using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esempio_ereditarieta
{
    //classe padre da cui potranno ereditare sia studente che docente
    internal class Persona
    {
        public string nome;
        public string cognome;
        public int anno_nascita;

        public void stampaInfo()
        {
            Console.WriteLine(this.nome + " " + this.cognome);
        }
    }
}
