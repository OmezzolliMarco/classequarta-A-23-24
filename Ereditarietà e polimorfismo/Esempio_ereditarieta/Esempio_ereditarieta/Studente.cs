using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esempio_ereditarieta
{
    internal class Studente:Persona
    {
        //attributi di base di Persona già presente perché si tratta di una classe 
        //ereditata

        //scrivere attributi specifici appartenenti solo alla classe Studente
        public string classe;
        public double media_voti;

        public void stampaInfo()
        {

        }
    }
}
