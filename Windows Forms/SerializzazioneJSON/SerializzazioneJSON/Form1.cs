using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace SerializzazioneJSON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            string path = Directory.GetCurrentDirectory() + "\\test.txt";
            string contenuto = File.ReadAllText(path);
            Console.WriteLine(contenuto);
            var coppie = contenuto.Split('\n');
            foreach (string line in coppie)
            {
                Console.WriteLine(line);
                var valori = line.Split(',');
                int a = int.Parse(valori[0]);
                int b = int.Parse(valori[1]);
                int res = a + b;
                Console.WriteLine(res);
            }
            //string path2 = Directory.GetCurrentDirectory() + "\\output.txt";
            //string content = "Classe 4ASA";
            //File.WriteAllText(path2, content);

            //string a = "Ciao-a-tutti";
            //var l = a.Split('-');


            
            //conversione oggetto a JSON
            //Persona p = new Persona
            //{
            //    nome = "Mario",
            //    cognome = "Rossi",
            //    anno_di_nascita = 2000
            //};
            //string json = JsonConvert.SerializeObject(p);
            //Console.WriteLine(json);

            ////accesso al file
            //string path = Directory.GetCurrentDirectory() + "\\persone.json";
            //string contenuto = File.ReadAllText(path);
            //List<Persona> lista = JsonConvert.DeserializeObject<List<Persona>>(contenuto);
            //Console.WriteLine(lista);
        }
    }
}
