using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esempio_ereditarieta
{
    internal class Docente:Persona
    {
        //anche in questo caso gli attributi e metodi non privati della classe Persona sono già presenti in Docente
        public string[] classi;
        public int anni_servizio;
        public string[] materie_insegnate;
    }
}
