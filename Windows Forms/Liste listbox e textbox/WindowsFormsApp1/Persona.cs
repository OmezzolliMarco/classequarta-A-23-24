using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Persona
    {
        public string nome;
        public string cognome;
        public int eta;
        public Persona(string nome, string cognome, int eta)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.eta = eta;
        }

        public string stampa()
        {
            return nome + " " + cognome;
        }
    }
}
