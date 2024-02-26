using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            getPokemon();
        }

        public async void getPokemon()
        {
            using (var http = new HttpClient()) {
                try {
                    var resp = await http.GetStringAsync("https://pokeapi.co/api/v2/pokemon/"+ pokeName.Text.ToLower());
                    dynamic? result = JsonConvert.DeserializeObject(resp);
                    string name = result["name"];
                    int weight = result["weight"];
                    string urlImage = result["sprites"]["front_default"];
                    string backImage = result["sprites"]["back_default"];
                    pokeFrame.Content = new Pokemon(name,urlImage,weight, backImage);
                }catch(HttpRequestException exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
        }


        

        
    
    }
}
