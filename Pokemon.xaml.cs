using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
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
    /// Логика взаимодействия для Pokemon.xaml
    /// </summary>
    public partial class Pokemon : Page
    {
        public Pokemon(string name, string urlImage, int weight, string backImage)
        {
            InitializeComponent();

            pokeName.Text = name;
            pokeWeight.Text = weight.ToString();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(urlImage);
            bitmap.EndInit();

            BitmapImage bitmap1 = new BitmapImage();
            bitmap1.BeginInit();
            bitmap1.UriSource = new Uri(backImage);
            bitmap1.EndInit();


            frontPIc.Source = bitmap;
            backPic.Source = bitmap1;
        }
    }
}
