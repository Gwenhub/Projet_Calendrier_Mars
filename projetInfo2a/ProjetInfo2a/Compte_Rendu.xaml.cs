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
    /// Logique d'interaction pour Compte_Rendu.xaml
    /// </summary>
    public partial class Compte_Rendu : Page
    {
        public Compte_Rendu()
        {
            InitializeComponent();
        }

        private void Modifier_CR(object sender, RoutedEventArgs e)
        {
            Modifier_Compte_Rendu.Visibility = Visibility.Hidden;
            Enregistrer_Compte_Rendu.Visibility = Visibility.Visible;
            Texte_1000_caract.Visibility = Visibility.Visible;
            CR.Visibility = Visibility.Visible;
        }

        private void Enregistrer_CR(object sender, RoutedEventArgs e)
        {
            Enregistrer_Compte_Rendu.Visibility = Visibility.Hidden;
            Texte_1000_caract.Visibility = Visibility.Hidden;
            CR.Visibility = Visibility.Hidden;
            Modifier_Compte_Rendu.Visibility = Visibility.Visible;
        }

    }
}
