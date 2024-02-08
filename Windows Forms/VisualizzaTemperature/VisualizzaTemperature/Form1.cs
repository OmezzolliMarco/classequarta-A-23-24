using System.ComponentModel;
using Newtonsoft.Json;

namespace VisualizzaTemperature
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //chiamata alla funzione asincrona
        }

        private async void getJsonButton(object sender, EventArgs e)
        {

            string apiUrl = "http://studinfo.altervista.org/apitest/retrive_data.php";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Effettua una richiesta GET all'API
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    // Verifica se la richiesta è andata a buon fine (codice di stato HTTP 200)
                    if (response.IsSuccessStatusCode)
                    {
                        // Leggi il contenuto della risposta come stringa JSON
                        string jsonResult = await response.Content.ReadAsStringAsync();

                        // Puoi elaborare il JSON come desideri, ad esempio, visualizzarlo in una TextBox
                        List<Temperatura> temperature = JsonConvert.DeserializeObject<List<Temperatura>>(jsonResult);

                        //visualizza i risultati nella listbox
                        listBox1.BeginUpdate();
                        listBox1.Items.Clear();
                        foreach(Temperatura t in temperature)
                        {
                            listBox1.Items.Add(t.toString());
                        }
                        listBox1.EndUpdate();
                    }
                    else
                    {
                        // Se la richiesta non è andata a buon fine, visualizza un messaggio di errore
                        MessageBox.Show($"Errore nella richiesta. Codice di stato: {response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    // Gestisci eventuali eccezioni durante la richiesta
                    MessageBox.Show($"Errore: {ex.Message}");
                }
            }
        }
    }
}