using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace CarteraClientes.WPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        string url = "https://localhost:44346/";
        List<Models.Cliente> lista = new List<Models.Cliente>();
        private async void btnObtener_Click(object sender, RoutedEventArgs e)
        {
            using(var cnxhttp=new HttpClient())
            {
                cnxhttp.BaseAddress = new Uri(url);
                cnxhttp.DefaultRequestHeaders.Clear();
                cnxhttp.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await cnxhttp.GetAsync("api/Clientes/ObtenerClientes");
                if(response.IsSuccessStatusCode){
                    var clienteresponse = response.Content.ReadAsStringAsync().Result;
                    lista = JsonConvert.DeserializeObject<List<Models.Cliente>>(clienteresponse);
                    dgvClientes.ItemsSource = lista;
                }
            }
        }
    }
}
