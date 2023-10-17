using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioPreVerifica
{
    internal class Program
    {
        public abstract class Persona
        {
            //metodi
            public abstract void definisciAnnoNascita();
            public abstract void impostaCodiceFiscale();
            public abstract void impostaTitoloDiStudio();
            public abstract void calcolaEta();
            public abstract void stampaInfo();
            public virtual void calcolaAnnoPensione()
            {

            }
        }

        public class Lavoratore : Persona
        {
            public string nome;
            public string cognome;
            public int annoNascita;
            public string cf;
            public string titoloDiStudio;

            public Lavoratore(string nome, string cognome)
            {
                this.nome = nome;
                this.cognome = cognome;
            }

            public override void definisciAnnoNascita()
            {
                this.annoNascita = int.Parse(Console.ReadLine());
            }

            public override void impostaCodiceFiscale()
            {
                this.cf = Console.ReadLine();
            }

            public override void impostaTitoloDiStudio()
            {
                this.titoloDiStudio = Console.ReadLine();
            }

            public override void calcolaEta()
            {
                int anno_corrente = 2023;
                Console.WriteLine("Età: " + (anno_corrente - annoNascita));
            }

            public override void stampaInfo()
            {
                Console.WriteLine("Nome: " + nome + " - Cognome: " + cognome + " ...");
            }

            public override void calcolaAnnoPensione()
            {
                int anno_pensione = this.annoNascita + 62;
                Console.WriteLine("Anno pensione: " + anno_pensione);
            }

            public void calcoloPensione(int N)
            {
                int[] anni = new int[N];
                Random r = new Random();
                double media = 0;
                for (int i = 0; i < N; i++)
                {
                    anni[i] = r.Next(1200, 1401);
                    media = media + anni[i];
                }
                media = media / N;
                Console.WriteLine(media);
            }

        }

        public class Pensionato : Persona
        {
            public string nome;
            public string cognome;
            public int annoNascita;
            public string cf;
            public string titoloDiStudio;

            public override void definisciAnnoNascita()
            {
                this.annoNascita = int.Parse(Console.ReadLine());
            }

            public override void impostaCodiceFiscale()
            {
                this.cf = Console.ReadLine();
            }

            public override void impostaTitoloDiStudio()
            {
                this.titoloDiStudio = Console.ReadLine();
            }

            public override void calcolaEta()
            {
                int anno_corrente = 2023;
                Console.WriteLine("Età: " + (anno_corrente - annoNascita));
            }

            public override void stampaInfo()
            {
                Console.WriteLine("Nome: " + nome + " - Cognome: " + cognome + " ...");
            }
        }

        static void Main(string[] args)
        {
            Lavoratore l = new Lavoratore("Mario", "Biondi");
            l.definisciAnnoNascita();
            l.calcolaAnnoPensione();
            Console.ReadLine();
        }
    }
}
