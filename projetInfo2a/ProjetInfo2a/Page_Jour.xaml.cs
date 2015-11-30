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
    /// Logique d'interaction pour Jour.xaml
    /// </summary>
    public partial class Jour : Page
    {
        public Jour()
        {
            InitializeComponent();
        }

        private void Consulter_CR(object sender, RoutedEventArgs e)
        {
            Compte_Rendu cr = new Compte_Rendu();
            this.NavigationService.Navigate(cr);
        }

        private void Voir_Activite(object sender, MouseButtonEventArgs e)
        {
            Activite activite = new Activite();
            this.NavigationService.Navigate(activite);
        }

    }
}
