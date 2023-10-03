using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassiAstratte
{
    //classe astratta deriva da Shape
    internal class TriangoloIsoscele : Shape
    {
        public double h, b, l;
        
        public TriangoloIsoscele(double h, double b, double l)
        {
            this.h = h;
            this.b = b;
            this.l = l;
        }

        public override double trovaArea()
        {
            return (h * b) / 2;
        }

        public override double trovaPerimetro()
        {
            return (l * 2) + b;
        }

        //metodi non derivati
        public double calcolaAltezza()
        {
            h = Math.Sqrt(Math.Pow(l, 2) - Math.Pow(b/2, 2));
            return h;
        }
    }
}
