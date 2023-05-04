using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListeDinamiche
{
    internal class Persona
    {
        public string nome;
        public string cognome;
        public int eta;
        public double conto;

        public Persona(string nome, string cognome)
        {
            this.nome = nome;
            this.cognome = cognome;
            eta = 0;
            conto = 0;
        }
    }
}
