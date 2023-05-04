namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        int punti_player = 0;
        int punti_computer = 0;
        public Form1()
        {
            InitializeComponent();

            //codice da spostare
            string path = Directory.GetCurrentDirectory() + "\\classifica.txt";
            string daStampare = "Giocatore: 10 & Computer: 15";
            //per stampare la stringa sul file
            File.WriteAllText(path, daStampare);
            //per aggiungere la stringa al file
            File.AppendAllText(path, daStampare);
            //per leggere la stringa dal file
            File.ReadAllText(path);

            //metodo alternativo con using e streamWriter
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine(daStampare);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int player = rand.Next(0, 3); //genera 0,1 o 2
            int computer = rand.Next(0, 3);

            //0 -> sasso, 1 -> carta, 2 -> forbici

            if(player == 0)
            {
                pictureBox1.BackgroundImage = Properties.Resources.rock;
            }
            else if(player == 1)
            {
                pictureBox1.BackgroundImage = Properties.Resources.paper;
            }
            else if(player == 2)
            {
                pictureBox1.BackgroundImage = Properties.Resources.scissor;
            }

            if (computer == 0)
            {
                pictureBox2.BackgroundImage = Properties.Resources.rock;
            }
            else if (computer == 1)
            {
                pictureBox2.BackgroundImage = Properties.Resources.paper;
            }
            else if (computer == 2)
            {
                pictureBox2.BackgroundImage = Properties.Resources.scissor;
            }

            //0 -> sasso, 1 -> carta, 2 -> forbici
            //controllo il vincitore
            if (player == computer)
            {
                //lascio il punteggio invariato
            }
            else if(player == 0 && computer == 1)
            {
                punti_computer += 1;
            }
            else if (player == 0 && computer == 2)
            {
                punti_player += 1;
            }
            else if (player == 1 && computer == 0)
            {
                punti_player += 1;
            }
            else if (player == 1 && computer == 2)
            {
                punti_computer += 1;
            }
            else if (player == 2 && computer == 0)
            {
                punti_computer += 1;
            }
            else if (player == 2 && computer == 1)
            {
                punti_player += 1;
            }

            label3.Text = punti_player.ToString();
            label4.Text = punti_computer.ToString();
        }
    }
}