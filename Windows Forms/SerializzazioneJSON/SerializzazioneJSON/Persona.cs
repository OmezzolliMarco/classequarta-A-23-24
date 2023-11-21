using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SerializzazioneJSON
{
    internal class Persona
    {
        public string nome { get; set; }
        public string cognome { get; set; }
        public int anno_di_nascita { get; set; }
        public Persona() 
        {
            
        }
    }
}
