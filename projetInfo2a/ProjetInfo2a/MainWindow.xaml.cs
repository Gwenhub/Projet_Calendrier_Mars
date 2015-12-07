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
        ClassMission _mission;

        public MainWindow()
        {
            _mission = new ClassMission();

            InitializeComponent();
            
            Page_Accueil accueil = new Page_Accueil();
            Page_Planning planning = new Page_Planning(_mission);
            Page_Recherche recherche = new Page_Recherche();
            Page_Exploration exploration = new Page_Exploration();
            
        }

        public ClassMission getMission()
        {
            return _mission;
        }

        private void Accueil_Click(object sender, RoutedEventArgs e)
        {
            _mainFrame.Source = new Uri("Page_Accueil.xaml", UriKind.Relative);
        }
        private void Planning_Click(object sender, RoutedEventArgs e)
        {
            _mainFrame.Source = new Uri("Page_Planning.xaml", UriKind.Relative);
        }
        private void Recherche_Click(object sender, RoutedEventArgs e)
        {
            _mainFrame.Source = new Uri("Page_Recherche.xaml", UriKind.Relative);
        }
        private void Exploration_Click(object sender, RoutedEventArgs e)
        {
            _mainFrame.Source = new Uri("Page_Exploration.xaml", UriKind.Relative);
        }

    }
}
