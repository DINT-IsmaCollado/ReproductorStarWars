using System;
using System.Collections.Generic;
using System.Linq;
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

namespace ReproductorStarWars
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MediaTrailer.LoadedBehavior = MediaState.Manual;
        }

        private void ButtonPlay_Click(object sender, RoutedEventArgs e)
        {
            MediaTrailer.Play();
        }

        private void ButtonPause_Click(object sender, RoutedEventArgs e)
        {
            MediaTrailer.Pause();
        }

        private void ButtonStop_Click(object sender, RoutedEventArgs e)
        {
            MediaTrailer.Stop();
        }

        private void CheckBoxMuted_Click(object sender, RoutedEventArgs e)
        {
            if(CheckBoxMuted.IsChecked == true)
                MediaTrailer.IsMuted = true;
            else
                MediaTrailer.IsMuted = false;
        }

        private void RadioButtonTrailer_Click(object sender, RoutedEventArgs e)
        {
            RadioButton r = sender as RadioButton;
            string path = Environment.CurrentDirectory;
            MediaTrailer.Source = new Uri(path + r.Tag);
        }
    }
}
