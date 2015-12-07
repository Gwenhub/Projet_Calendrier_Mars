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
    public partial class Page_Compte_Rendu : Page
    {
        ClassCompteRendu _cr;

        public Page_Compte_Rendu(ClassCompteRendu cr)
        {
            _cr = cr;

            InitializeComponent();
        }

        private void Modifier_CR(object sender, RoutedEventArgs e)
        {
            Bouton_Modifier_CR.Visibility = Visibility.Hidden;
            Bouton_Enregistrer_CR.Visibility = Visibility.Visible;
            Texte_1000_caract.Visibility = Visibility.Visible;
            Case_Texte_CR.Visibility = Visibility.Visible;
            Case_Texte_CR_MAJ.Visibility = Visibility.Hidden;
        }

        private void Enregistrer_CR(object sender, RoutedEventArgs e)
        {
            Bouton_Enregistrer_CR.Visibility = Visibility.Hidden;
            Texte_1000_caract.Visibility = Visibility.Hidden;
            Case_Texte_CR.Visibility = Visibility.Hidden;
            Bouton_Modifier_CR.Visibility = Visibility.Visible;
            Case_Texte_CR_MAJ.Visibility = Visibility.Visible;
        }

    }
}
