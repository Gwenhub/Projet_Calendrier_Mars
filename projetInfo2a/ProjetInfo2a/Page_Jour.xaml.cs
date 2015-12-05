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
    public partial class Page_Jour : Page
    {
        public Page_Jour()
        {
            InitializeComponent();
        }

        private void Consulter_CR(object sender, RoutedEventArgs e)
        {
            Page_Compte_Rendu cr = new Page_Compte_Rendu();
            this.NavigationService.Navigate(cr);
        }

        private void Voir_Activite(object sender, MouseButtonEventArgs e)
        {
            Page_Activite activite = new Page_Activite();
            this.NavigationService.Navigate(activite);
        }

    }
}
