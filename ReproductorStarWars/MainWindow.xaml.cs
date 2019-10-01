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
            string path = Environment.CurrentDirectory;
            if (RadioButtonTrailer1.IsChecked == true)
            {
                MediaTrailer.Source = new Uri(path + @"\trailer1.mp4");
                MediaTrailer.Play();
                
            }
            if (RadioButtonTrailer2.IsChecked == true)
            {
                MediaTrailer.Source = new Uri(path + @"\trailer2.mp4");
                MediaTrailer.Play();
            }
        }

        private void ButtonPause_Click(object sender, RoutedEventArgs e)
        {
            MediaTrailer.Pause();
        }

        private void ButtonStop_Click(object sender, RoutedEventArgs e)
        {
            MediaTrailer.Stop();
        }

        private void CheckBoxMuted_Checked(object sender, RoutedEventArgs e)
        {
            MediaTrailer.IsMuted = true;
        }

        private void CheckBoxMuted_Unchecked(object sender, RoutedEventArgs e)
        {
            MediaTrailer.IsMuted = false;
        }
    }
}
