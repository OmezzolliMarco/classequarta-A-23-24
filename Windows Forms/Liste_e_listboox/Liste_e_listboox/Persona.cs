using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liste_e_listboox
{
    internal class Persona
    {
        public string nome;
        public string cognome;
        public int anno_nascita;

        public Persona(string nome, string cognome, int anno_nascita)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.anno_nascita = anno_nascita;
        }
    }
}
