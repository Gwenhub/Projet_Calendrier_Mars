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
    /// Logique d'interaction pour Accueil.xaml
    /// </summary>
    public partial class Accueil : Page
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void AfficherPlanning(object sender, RoutedEventArgs e)
        {
            Planning planning = new Planning();
            this.NavigationService.Navigate(planning);
            /*Compte_Rendu cr = new Compte_Rendu();
            this.NavigationService.Navigate(cr);*/

        }
        private void AfficherExploration(object sender, RoutedEventArgs e)
        {
            Exploration exploration = new Exploration();
            this.NavigationService.Navigate(exploration);
        }

        private void AfficherRecherche(object sender, RoutedEventArgs e)
        {
            Recherche recherche = new Recherche();
            this.NavigationService.Navigate(recherche);
        }

    }
}
