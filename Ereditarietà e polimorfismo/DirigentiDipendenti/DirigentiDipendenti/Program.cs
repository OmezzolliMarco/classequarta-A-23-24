using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirigentiDipendenti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dirigente d = new Dirigente();
            Impiegato impo = new Impiegato();

            impo.dirigente = d;
        }
    }
}
