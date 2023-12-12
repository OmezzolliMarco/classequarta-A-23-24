using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizzaTemperature
{
    //dichiarazione della classe che deve contenere le informazioni
    internal class Temperatura
    {
        public int ID;
        public string datatempo;
        public double temperatura;

        public string toString()
        {
            return "ID: "+ID+" - Timestamp: " + datatempo + " - Temp: " + temperatura + "";
        }
    }
}
