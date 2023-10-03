using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassiAstratte
{
    internal class Rettangolo : Shape
    {
        //attributi
        public double h, b;
        //costruttore
        public Rettangolo(double h, double b )
        {
            this.h = h;
            this.b = b;
        }

        //overriding dei metodi della classe astratta padre
        public override double trovaArea()
        { 
            return h * b;
        }

        public override double trovaPerimetro()
        {
            return h * 2 + b * 2;
        }

        //inizio scrittura metodi propri della classe Rettangolo
        //che non richiedono override
    }
}
