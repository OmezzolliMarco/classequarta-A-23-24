using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcolatrice
{
    public partial class Form1 : Form
    {
        string numero = "Inserisci un numero";
        bool virgola = false; //non ancora inserite virgole
        public Form1()
        {
            InitializeComponent();
            label1.Text = numero; //output
            numero = ""; //vuoto e posso riempirlo con i numeri che servono a me
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numero = numero + "1";
            label1.Text = numero;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numero = numero + "2";
            label1.Text = numero;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            numero = numero + "3";
            label1.Text = numero;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            numero = numero + "4";
            label1.Text = numero;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            numero = numero + "5";
            label1.Text = numero;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            numero = numero + "6";
            label1.Text = numero;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            numero = numero + "7";
            label1.Text = numero;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            numero = numero + "8";
            label1.Text = numero;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            numero = numero + "9";
            label1.Text = numero;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            numero = numero + "0";
            label1.Text = numero;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(virgola == false)
            {
                numero = numero + ".";
                label1.Text = numero;
                virgola = true; 
            }
            
        }
    }
}
