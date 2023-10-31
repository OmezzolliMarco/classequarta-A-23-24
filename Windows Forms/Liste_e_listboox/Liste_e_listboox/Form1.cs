namespace Liste_e_listboox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //creazione di una lista di persone
            Persona p1 = new Persona("Mario", "Rossi", 1990);
            Persona p2 = new Persona("Andrea", "Bianchi", 1998);

            List<Persona> persone = new List<Persona>();
            persone.Add(p1);
            persone.Add(p2);

            //aggiorno la listbox
            listBox1.BeginUpdate();
            foreach (Persona p in persone)
            {
                listBox1.Items.Add(p.nome + " " + p.cognome);
            }
            listBox1.EndUpdate();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //leggo il contenuto dell'elemento selezionato
            string s = listBox1.SelectedItem.ToString();

            //leggo l'indice dell'elemento selezionato
            int i = listBox1.SelectedIndex;
        }
    }
}