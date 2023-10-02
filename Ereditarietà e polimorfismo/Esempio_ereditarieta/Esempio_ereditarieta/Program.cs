using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esempio_ereditarieta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            Studente studente = new Studente();
            Docente docente = new Docente();

            studente.nome = "Mario";
            docente.nome = "Franco";

            studente.stampaInfo();
        }
    }
}
