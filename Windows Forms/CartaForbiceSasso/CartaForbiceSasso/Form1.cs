using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CartaForbiceSasso
{
    public partial class Form1 : Form
    {
        List<Giocata> list;
        public Form1()
        {
            InitializeComponent();
            list = new List<Giocata>();

            var gioco1 = new Giocata("Mario", "Luigi", true);
            var gioco2 = new Giocata("Mario", "Luigi", false);

            list.Add(gioco1);
            list.Add(gioco2);

            listBox1.BeginUpdate();
            foreach(var g in list)
            {
                listBox1.Items.Add(g.toString());
            }
            listBox1.EndUpdate();
        }

        public string calcolaVincitore(int r1, int r2)
        {
            /*
             * 0 -> sasso
             * 1 -> carta
             * 2 -> forbice
             */
            if (r1 == r2)
            {
                return "Pareggio";
            }
            else if(r1 == 0 && r2 == 1)
            {
                return "Vince Player2";
            }
            else if(r1 == 0 && r2 == 2)
            {
                return "Vince Player1";
            }
            else if (r1 == 1 && r2 == 0)
            {
                return "Vince Player1";
            }
            else if(r1 == 1 && r2 == 2)
            {
                return "Vince Player2";
            }
            else if(r1 == 2 && r2 == 0)
            {
                return "Vince Player2";
            }
            else if(r1 == 2 && r2 == 1)
            {
                return "Vince Player1";
            }
            return "Errore nel calcolo del vincitore";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            var r1 = r.Next(0,3);
            var r2 = r.Next(0,3);
            /*
             * 0 -> sasso
             * 1 -> carta
             * 2 -> forbice
             */

            if(r1 == 0)
            {
                pictureBox1.BackgroundImage = CartaForbiceSasso.Properties.Resources.stone;
            }
            else if(r1 == 1)
            {
                pictureBox1.BackgroundImage = CartaForbiceSasso.Properties.Resources.paper;
            }
            else
            {
                pictureBox1.BackgroundImage = CartaForbiceSasso.Properties.Resources.scissor;
            }

            if (r2 == 0)
            {
                pictureBox2.BackgroundImage = CartaForbiceSasso.Properties.Resources.stone;
            }
            else if (r2 == 1)
            {
                pictureBox2.BackgroundImage = CartaForbiceSasso.Properties.Resources.paper;
            }
            else
            {
                pictureBox2.BackgroundImage = CartaForbiceSasso.Properties.Resources.scissor;
            }

            label3.Text = calcolaVincitore(r1, r2);

        }
    }
}
