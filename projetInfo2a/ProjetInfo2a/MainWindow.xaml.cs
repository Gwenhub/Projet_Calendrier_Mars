using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Xml.Linq;

namespace ProjetInfo2a
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            Accueil accueil = new Accueil();
            Planning planning = new Planning();
            Recherche recherche = new Recherche();
            Exploration exploration = new Exploration();

        }
        private void Accueil_Click(object sender, RoutedEventArgs e)
        {
            _mainFrame.Source = new Uri("Accueil.xaml", UriKind.Relative);
        }
        private void Planning_Click(object sender, RoutedEventArgs e)
        {
            _mainFrame.Source = new Uri("Planning.xaml", UriKind.Relative);
        }
        private void Recherche_Click(object sender, RoutedEventArgs e)
        {
            _mainFrame.Source = new Uri("Recherche.xaml", UriKind.Relative);
        }
        private void Exploration_Click(object sender, RoutedEventArgs e)
        {
            _mainFrame.Source = new Uri("Exploration.xaml", UriKind.Relative);
        }

    }
}
