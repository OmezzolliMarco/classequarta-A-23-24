namespace ListeDinamiche
{
    public partial class Form1 : Form
    {
        //creo la lista come attributo in modo che sia accessibile a tutti i metodi

        List<Persona> persone;
        public Form1()
        {
            InitializeComponent();
            Persona p1 = new Persona("Mario", "Rossi");
            Persona p2 = new Persona("Luigi", "Verdi");

            //istanzio la lista come lista vuota
            persone = new List<Persona>();

            //aggiungo le persone alla lista
            persone.Add(p1);
            persone.Add(p2);

            //aggiorno la list box
            listBox1.BeginUpdate();
            foreach(Persona p in persone)
            {
                listBox1.Items.Add(p.nome + " " + p.cognome);
            }
            listBox1.EndUpdate();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string contenuto = listBox1.SelectedItem.ToString(); //metodo toString necessario per ottenere il testo dell'elemento selezionato
            int indice = listBox1.SelectedIndex; //recupero l'indice selezionato

            //dall'indice ricavo l'elemento in posizione indice per poter operare al suo interno
            label1.Text = persone[indice].nome + " " + persone[indice].cognome;

            textBox1.Text = persone[indice].eta.ToString(); //riporto l'età all'interno della text box, in modo da renderla modificabile

            //inserisco il saldo del conto
            label2.Text = persone[indice].conto.ToString();
        }

        //click pulsante di salvataggio
        private void button1_Click(object sender, EventArgs e)
        {
            //recupero l'indice dell'elemento selezionato
            int indice = listBox1.SelectedIndex;
            //aggiorno il valore legato all'istanza di persona nella lista
            persone[indice].eta = int.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        //pulsante aggiunta 100 €
        private void button2_Click(object sender, EventArgs e)
        {
            int indice = listBox1.SelectedIndex;
            persone[indice].conto += 100;
            label2.Text = persone[indice].conto.ToString();
            if (persone[indice].conto >= 0)
            {
                label2.ForeColor = Color.Green;
            }
            else
            {
                label2.ForeColor = Color.Red;
                label2.Text = "0";
            }
        }

        //pulsante di riduzione 100 €
        private void button3_Click(object sender, EventArgs e)
        {
            int indice = listBox1.SelectedIndex;
            persone[indice].conto -= 100;
            label2.Text = persone[indice].conto.ToString();
            if (persone[indice].conto >= 0)
            {
                label2.ForeColor = Color.Green;
            }
            else
            {
                label2.ForeColor = Color.Red;
                label2.Text = "0";
            }
        }
    }
}