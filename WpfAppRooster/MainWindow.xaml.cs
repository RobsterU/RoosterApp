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

namespace WpfAppRooster
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LesRooster hetRooster = new LesRooster();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnOpslaan_Click(object sender, RoutedEventArgs e)
        {
            string vaknaam = txtVak.Text;
            string lokaal = txtLokaal.Text;
            string dag = txtDag.Text;
            string uur = txtUur.Text;

            Les deLes = new Les();
           
        }
    }
}
