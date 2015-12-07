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
        ClassJour _jour;

        public Page_Jour(ClassJour jour)
        {
            _jour = jour;

            InitializeComponent();
        }

        private void afficheActivites()
        {

            DataGridActivites.ItemsSource = _jour.getActivite();

        }

        private void Consulter_CR(object sender, RoutedEventArgs e)
        {
            ClassCompteRendu cr = _jour.getCR();
            Page_Compte_Rendu page_cr = new Page_Compte_Rendu(cr);
            this.NavigationService.Navigate(page_cr);
        }

        private void Voir_Activite(double hDeb, double hFin, MouseButtonEventArgs e)
        {
            double[] creneau = new double[2] { hDeb, hFin };
            ClassActivite act = _jour.getActivite()[creneau];
            Page_Activite activite = new Page_Activite(act);
            this.NavigationService.Navigate(activite);
        }

    }
}
