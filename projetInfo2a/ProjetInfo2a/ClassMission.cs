using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml;

namespace ProjetInfo2a
{
    public class ClassMission
    {
        private List<String> _activites;
        private int _nbAstraunautes;
        private List<String> _astronautes;
        private ClassLieu _lieu;
        private int _jourJ;
        private DateTime _t0;
        private int _duree; //en nb de jours
        private ClassJour _journeeDefaut;
        private Dictionary<int, ClassJour> _planning;

        //constructeur par défaut, qui initialise la mission en chargeant les données
        public ClassMission()
        {
            _activites = new List<string>();
            _astronautes = new List<string>();
            _lieu = new ClassLieu();
            _journeeDefaut = new ClassJour(this);
            _planning = new Dictionary<int, ClassJour>();

            chargerInfo();
            initialisePlanning();
        }

        // accesseurs
        public List<String> getActivites()
        {
            return _activites;
        }
       
        public int getJourJ()
        {
            return _jourJ;
        }

        public DateTime getT0()
        {
            return _t0;
        }

        public int getDuree()
        {
            return _duree;
        }

        public void setDuree(int nbJours)
        {
            _duree = nbJours;
        }
        public Dictionary<int,ClassJour> getPlanning()
        {
            return _planning;
        }

        // recupère le numéro du jour Martien courant à partir de la date Terrienne
        public void setJourJ()
        {
            TimeSpan tpsEcoule = DateTime.Today - _t0;
            double tpsEcouleHeures = tpsEcoule.TotalHours;
            _jourJ = (int)(1 + tpsEcouleHeures / 24.4);
        }

        // désérialisation globale qui appelle les methodes de chaque champ de Mission
        public void chargerInfo()
        {
            XmlDocument xmlDoc = new XmlDocument();

            try
            {
                xmlDoc.Load("infosGenerales.xml"); //stocké dans le bin/debug
            }
            catch
            {
                string message = "Le fichier XML de sauvegarde n'a pas été trouvé dans le répertoire.";
                MessageBox.Show(message);
                return;
            }

            // désérialisations
            load_mission(xmlDoc);
            load_activites(xmlDoc);
            load_lieu(xmlDoc);
            load_astronautes(xmlDoc);
            load_journeeDefaut(xmlDoc);

        }

        // désérialisation de <mission>
        private void load_mission(XmlDocument doc)
        {
            _lieu = new ClassLieu();
            // on crée un noeud pour la balise mission
            XmlNode node = doc.SelectSingleNode("/informations/mission");

            //on recupere son t0 dans l'attribut de la balise du .xml
            XmlAttribute xml_attr = node.Attributes["t0"];

            // on affecte le champ t0 de la Mission avec l'attribut qu'on vient de récup
            _t0 = DateTime.Parse(xml_attr.Value);

            //idem pour le champ duree
            xml_attr = node.Attributes["duree"];
            _duree = int.Parse(xml_attr.Value);
        }

        // désérialisation de <lieu>
        private void load_lieu(XmlDocument doc)
        {
            _lieu = new ClassLieu();
            // on crée un noeud pour la balise lieu
            XmlNode node = doc.SelectSingleNode("/informations/lieu");

            //on recupere son nom dans l'attribut de la balise du .xml
            XmlAttribute xml_attr = node.Attributes["nom"];

            // on affecte la propriété _lieu._nom avec l'attribut qu'on vient de récup
            _lieu.setNom(xml_attr.Value);

            //idem pour la balise carte de lieu
            node = doc.SelectSingleNode("/informations/lieu/carte");
            xml_attr = node.Attributes["image"];
            _lieu.setCarte(xml_attr.Value);

            xml_attr = node.Attributes["echelle"];
            _lieu.setEchelle(int.Parse(xml_attr.Value));

            //idem pour la balise position de lieu
            node = doc.SelectSingleNode("/informations/lieu/position");
            xml_attr = node.Attributes["longitude"];
            XmlAttribute xml_attr2 = node.Attributes["latitude"];
            _lieu.setPosition(double.Parse(xml_attr.Value), double.Parse(xml_attr2.Value));
        }

        // désérialisation de <activites>
        private void load_activites(XmlDocument doc)
        {
            _activites = new List<String>();
            XmlNodeList nl = doc.SelectNodes("/informations/activites/activite");
            foreach (XmlNode node in nl) // pour chaque activite de activites
            {
                //on recupere sa categorie dans l'attribut de la balise du .xml
                XmlAttribute xml_attr = node.Attributes["categorie"];
                //on instancie un string contenant avec l'attribut qu'on vient de récup
                String activite = xml_attr.Value;

                xml_attr = node.Attributes["sous-categorie"];
                activite += " / " + xml_attr.Value;

                //idem pour l'attribut nom 
                xml_attr = node.Attributes["nom"];
                activite += " / " + xml_attr.Value;

                // on ajoute l'activité à la liste d'activités de la mission
                _activites.Add(activite);
            }
        }

        //désérialisation de <astonautes>
        private void load_astronautes(XmlDocument doc)
        {
            XmlNode n = doc.SelectSingleNode("/informations/astronautes/effectif");
            XmlAttribute xml_attr = n.Attributes["nb"];
            _nbAstraunautes = int.Parse(xml_attr.Value);

            _astronautes = new List<String>();
            XmlNodeList nl = doc.SelectNodes("/informations/astronautes/astronaute");
            foreach (XmlNode node in nl)
            {
                String astronaute;
                xml_attr = node.Attributes["nom"];
                astronaute = xml_attr.Value;

                _astronautes.Add(astronaute);
            }
        }

        // désérialisation de journeeDefaut
        private void load_journeeDefaut(XmlDocument doc)
        {
            _journeeDefaut = new ClassJour(this);

            XmlNodeList nl = doc.SelectNodes("/informations/journeeDefaut/activite");
            foreach (XmlNode node in nl)
            {
                ClassActivite activite = new ClassActivite();
                XmlAttribute xml_attr = node.Attributes["categorie"];
                activite.setCategorie(xml_attr.Value);
                xml_attr = node.Attributes["nom"];
                activite.setCategorie(activite.getCategorie() + " / " + xml_attr);

                xml_attr = node.Attributes["hdebut"];
                activite.setHeureDeb(int.Parse(xml_attr.Value));
                xml_attr = node.Attributes["hfin"];
                activite.setHeureFin(int.Parse(xml_attr.Value));

                _journeeDefaut.ajouterActivite(activite);
            }
        }

        // remplissage du planning par défaut
        public void initialisePlanning()
        {
            for (int i = 1; i <= _duree; i++)
            {
                _planning.Add(i, _journeeDefaut);
            }
        }
    }
}
