using System.IO;
using System.Media;
using System.Numerics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace GraHistoria
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
        string nick = "";
        int dni = 1;
        private void zacznij_Click(object sender, RoutedEventArgs e)
        {
            stackpanel2row01.Visibility = Visibility.Visible;
            stackpanel1row0.Visibility = Visibility.Collapsed;
            stackpanel1row1.Visibility = Visibility.Collapsed;


        }

        private void ustawienia_Click(object sender, RoutedEventArgs e)
        {
            stackpanel1row1.Visibility = Visibility.Collapsed;
            stackpanelustawieniarow1.Visibility = Visibility.Visible;
        }

        private void wyjdz_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void wroc_Click(object sender, RoutedEventArgs e)
        {
            stackpanelustawieniarow1.Visibility= Visibility.Collapsed;
            stackpanel1row1.Visibility= Visibility.Visible;
           
        }

        private void zacznij2_Click(object sender, RoutedEventArgs e)
        {
            
            stackpanel2row01.Visibility= Visibility.Collapsed;
            stackpanel3.Visibility= Visibility.Visible;
        }

        private void nickpole_LostFocus(object sender, RoutedEventArgs e)
        {
            if (nickpole.Text.Length > 0)
            {
                zacznij2.Visibility = Visibility.Visible ;
                n.Visibility = Visibility.Collapsed ;
            }
        }

        private void tak1_Click(object sender, RoutedEventArgs e)
        {
            stackpanel3.Visibility = Visibility.Collapsed;
            stackpanel41.Visibility = Visibility.Visible;
        }

        private void nie1_Click(object sender, RoutedEventArgs e)
        {
            stackpanel3.Visibility = Visibility.Collapsed;
            stackpanel42.Visibility = Visibility.Visible;
        }

        private void wyjdzzdomu_Click(object sender, RoutedEventArgs e)
        {
            stackpanel41.Visibility= Visibility.Collapsed;
            stackpanel51.Visibility = Visibility.Visible;
        }

        private void zostanwdomu_Click(object sender, RoutedEventArgs e)
        {
            stackpanel41.Visibility=Visibility.Collapsed;
            stackpanelzostan.Visibility= Visibility.Visible;
        }
        private MediaPlayer player = new MediaPlayer();

        private void wejsciebiedra_Click(object sender, RoutedEventArgs e)
        {
            stackpanel42.Visibility= Visibility.Collapsed;
            stackpanel52.Visibility = Visibility.Visible;
            player.Open(new Uri("C:\\Users\\mixu1\\Pictures\\siren-12418.mp3"));
            player.Play();
        }

        private void niebierz_Click(object sender, RoutedEventArgs e)
        {
            stackpanel51.Visibility = Visibility.Collapsed;
            stackpanel511.Visibility = Visibility.Visible;
        }

        private void bierz_Click(object sender, RoutedEventArgs e)
        {
            stackpanel51.Visibility= Visibility.Collapsed;
            stackpanel512.Visibility = Visibility.Visible;
        }

        private void wrocbiedronka_Click(object sender, RoutedEventArgs e)
        {
            stackpanel52.Visibility = Visibility.Collapsed;
            stackpanel41.Visibility = Visibility.Visible;

        }

        private void idzmiastobiedronka_Click(object sender, RoutedEventArgs e)
        {
            stackpanel52.Visibility = Visibility.Collapsed;
            stackpanel51.Visibility = Visibility.Visible;
        }
        private MediaPlayer spanie = new MediaPlayer();
        private void idzspac_Click(object sender, RoutedEventArgs e)
        {
            spanie.Open(new Uri("C:\\Users\\mixu1\\Pictures\\z-z-z-z-z-z.mp3"));
            spanie.Play();
            Thread.Sleep(1000);
            spanie.Volume = 30;
            stackpanelzostan.Visibility = Visibility.Collapsed;
            wstanie.Visibility = Visibility.Visible;

        }

        private void wyjrzyj_Click(object sender, RoutedEventArgs e)
        {
            wstanie.Visibility = Visibility.Collapsed;
            wyjrzyjzaokno.Visibility = Visibility.Visible;
            dni++;
        }

        private async void napijsiewody_Click(object sender, RoutedEventArgs e)
        {
            wstanie.Visibility = Visibility.Collapsed;
            stpnapij.Visibility = Visibility.Visible;

            pijesz.Content = "Pijesz wode.";
            await Task.Delay(1000);

            pijesz.Content = "Pijesz wode..";
            await Task.Delay(1000);

            pijesz.Content = "Pijesz wode...";
            await Task.Delay(1000);
            pijesz.Content = "Pijesz wode.";
            await Task.Delay(1000);

            pijesz.Content = "Pijesz wode..";
            await Task.Delay(1000);

            pijesz.Content = "Pijesz wode...";
            await Task.Delay(1000);
            stpnapij.Visibility = Visibility.Collapsed;
            wstanie.Visibility = Visibility.Visible;
        }


        private void ogladajtt_Click(object sender, RoutedEventArgs e)
{
    wstanie.Visibility = Visibility.Collapsed;
    stpogladaj.Visibility = Visibility.Visible;

    Film.Source = new Uri(@"C:\Users\mixu1\Desktop\tiktok1.mp4");
    Film.LoadedBehavior = MediaState.Manual;
    Film.UnloadedBehavior = MediaState.Stop;
    Film.Play();
}


        private void Film_MediaOpened(object sender, RoutedEventArgs e)
        {
           
        }
        private void Film_MediaFailed(object sender, ExceptionRoutedEventArgs e)
        {
            MessageBox.Show("Błąd odtwarzania: " + e.ErrorException.Message);
        }

        private void tiktokstop_Click(object sender, RoutedEventArgs e)
        {
            Film.Stop();
            stpogladaj.Visibility= Visibility.Collapsed;
           wyjdztiktok.Visibility= Visibility.Visible;
        }

        private void wyjrzyjzaokno1_Click(object sender, RoutedEventArgs e)
        {
            wyjdztiktok.Visibility = Visibility.Collapsed;
            wyjrzyjzaokno.Visibility = Visibility.Visible;
        }

        private async void napijsie1_Click(object sender, RoutedEventArgs e)
        {
            wstanie.Visibility = Visibility.Collapsed;
            stpnapij.Visibility = Visibility.Visible;

            pijesz.Content = "Pijesz wode.";
            await Task.Delay(1000);

            pijesz.Content = "Pijesz wode..";
            await Task.Delay(1000);

            pijesz.Content = "Pijesz wode...";
            await Task.Delay(1000);
            pijesz.Content = "Pijesz wode.";
            await Task.Delay(1000);

            pijesz.Content = "Pijesz wode..";
            await Task.Delay(1000);

            pijesz.Content = "Pijesz wode...";
            await Task.Delay(1000);
            stpnapij.Visibility = Visibility.Collapsed;
            wstanie.Visibility= Visibility.Visible;
        }

        private void PrzestanWygladacZaOkno_Click(object sender, RoutedEventArgs e)
        {
            wyjrzyjzaokno.Visibility = Visibility.Collapsed;
            codalejzaokno.Visibility= Visibility.Visible;
        }

        private void zastrzel_Click(object sender, RoutedEventArgs e)
        {
            codalejzaokno.Visibility= Visibility.Collapsed;
            SmiercStrzal.Visibility= Visibility.Visible;
        }

        private void wyjdznamiastoo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void usiadznakanapie_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}