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

namespace ProjetInfo2a
{
    /// <summary>
    /// Logique d'interaction pour Activite.xaml
    /// </summary>
    public partial class Activite : Page
    {
        public Activite()
        {
            InitializeComponent();
        }

        private void Bouton_Carte(object sender, RoutedEventArgs e)
        {
            Exploration exploration = new Exploration();
            this.NavigationService.Navigate(exploration);

        }
    }
}
