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

namespace LetturaScritturaFile
{
    public partial class Form1 : Form
    {

        //attributo di form1
        string path = Directory.GetCurrentDirectory()+"\\test.txt";
        public Form1()
        {
            InitializeComponent();

            //carico informazioni salvate
            if(File.Exists(path)) //input
            {
                //caricare le informazioni nel programma (elaborazione)
                var contenutoFile = File.ReadAllText(path); //legge la stringa dal file
                var nomi = contenutoFile.Split('-'); //array di String

                label3.Text = nomi[0];
                label4.Text = nomi[1];
            }
            else
            {
                //non carico le informazioni, ma creo il file predisposto
                // per il salvataggio
                var contenuto = ""; //creo stringa vuota da scrivere nel file
                File.WriteAllText(path, contenuto);
            }

            /*inizio alternativo con try catch per lettura informazioni da file*/
            try
            {
                //prova a fare qualcosa
                var contenutoFile = File.ReadAllText(path); //legge la stringa dal file
                var nomi = contenutoFile.Split('-'); //array di String

                label3.Text = nomi[0];
                label4.Text = nomi[1];
            }
            catch(Exception ex)
            {
                //gestisco l'errore
                label3.Text="Player1";
                label4.Text = "Player2";
            }

        }

        //inizio di input
        private void button1_Click(object sender, EventArgs e)
        {
            //input
            var nome1 = textBox1.Text;
            var nome2 = textBox2.Text;

            //elaborazione
            var contenuto = nome1 + "-" + nome2;
            File.WriteAllText(path, contenuto);

            //output
            var contenutoFile = File.ReadAllText(path); //legge la stringa dal file
            var nomi = contenutoFile.Split('-'); //array di String

            label3.Text = nomi[0];
            label4.Text = nomi[1];
        }
    }
}
