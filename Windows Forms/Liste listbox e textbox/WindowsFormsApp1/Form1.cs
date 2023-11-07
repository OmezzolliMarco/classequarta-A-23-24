using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        List<Persona> lista;
        public Form1()
        {
            InitializeComponent();
            //inizio la personalizzazione
            Persona p1 = new Persona("Mario", "Rossi", 50);
            Persona p2 = new Persona("Gigi", "Verdi", 25);

            //creo l'istanza della lista nel costruttore
            lista = new List<Persona>();
            lista.Add(p1);
            lista.Add(p2);

            //istanziano e si modificano (per la prima volta) nel costruttore
            listaPersone.BeginUpdate();
            foreach (Persona p in lista)
            {
                //aggiungo quello che l'utente deve vedere
                listaPersone.Items.Add(p.nome + " " + p.cognome + " - " + p.eta.ToString());
            }
            listaPersone.EndUpdate();

        }

        private void listaPersone_SelectedIndexChanged(object sender, EventArgs e)
        {
            //leggere l'indice che ho selezionato
            var indice = listaPersone.SelectedIndex;
            //accedere all'elemento della lista persone a quell'indice
            Persona selezionata = lista[indice];
            //stampare le info di persona sulla label
            //label1.Text = selezionata.nome + " " + selezionata.cognome;

            textBox1.Text = selezionata.eta.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //recupero il valore dalla textbox
            var valore = int.Parse(textBox1.Text);

            //recupero l'indice selezionato
            var indice = listaPersone.SelectedIndex;

            //cambio l'età di quella persona selezionata
            lista[indice].eta = valore;

            listaPersone.BeginUpdate();
            //svuoto la lista del listbox
            listaPersone.Items.Clear();
            foreach (Persona p in lista)
            {
                listaPersone.Items.Add(p.nome + " " + p.cognome + " - " + p.eta.ToString());
            }
            listaPersone.EndUpdate();
            
        }
    }
}
