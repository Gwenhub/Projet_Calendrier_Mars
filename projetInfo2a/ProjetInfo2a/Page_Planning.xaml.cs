﻿using System;
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
    /// Logique d'interaction pour Planning.xaml
    /// </summary>
    public partial class Page_Planning : Page
    {
        ClassMission _mission;

        public Page_Planning(ClassMission mission)
        {
            _mission = mission;

            InitializeComponent();
        }

        private void AfficherJourJ(object sender, MouseButtonEventArgs e)
        {
            Label labelJour = sender as Label;
            int nbJour = int.Parse(labelJour.Content.ToString());
            MessageBox.Show("vous cherchez à afficher le jour "+ 
                _mission.getPlanning()[11].getNumero().ToString(), "petit test");
            /*ClassJour trouveJour =_mission.getPlanning()[nbJour];
            Page_Jour jour = new Page_Jour(trouveJour);
            this.NavigationService.Navigate(jour);
            */
        }
        
    }
}
