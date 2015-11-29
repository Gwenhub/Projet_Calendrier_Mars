using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml;

namespace ProjetInfo2a
{
    class ClassMission
    {
        private List<ClassActivite> _activites;
        private int _nbAstraunautes;
        private List<String> _astronautes;
        private ClassLieu _lieu;
        private int _jourJ;
        private DateTime _t0;
        private ClassJour _journeeDefaut;

        // methode de désérialisation globale qui appelle les methodes de chaque champ de Mission
        public void recupXML()
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
            load_activites(xmlDoc);
            load_lieu(xmlDoc);

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
            _lieu.setEchelle(xml_attr.Value);

            //idem pour la balise position de lieu
            node = doc.SelectSingleNode("/informations/lieu/position");
            xml_attr = node.Attributes["longitude"];
            XmlAttribute xml_attr2 = node.Attributes["latitude"];
            _lieu.setPosition(xml_attr.Value, xml_attr2.Value);
        }

        // désérialisation de <activites>
        private void load_activites(XmlDocument doc)
        {
            _activites = new List<ClassActivite>();
            XmlNodeList nl = doc.SelectNodes("/informations/activites/activite");
            foreach (XmlNode node in nl) // pour chaque activite de activites
            {
                //on recupere sa categorie dans l'attribut de la balise du .xml
                XmlAttribute xml_attr = node.Attributes["categorie"];
                //on instancie un objet ClassActivite
                ClassActivite activite = new ClassActivite();
                //dont on affecte la propriété _categorie avec l'attribut qu'on vient de récup
                activite.setCategorie(xml_attr.Value);

                xml_attr = node.Attributes["sous-categorie"];
                activite.setCategorie(activite.getCategorie() + " / " + xml_attr.Value);

                //idem pour l'attribut nom 
                xml_attr = node.Attributes["nom"];
                activite.setNom(xml_attr.Value);

                // on ajoute l'activité à la liste d'activités de la mission
                _activites.Add(activite);
            }
        }

        //désérialisation de <astonautes>
        private void load_astronautes(XmlDocument doc)
        {
            _astronautes = new List<String>();
            XmlNodeList nl = doc.SelectNodes("/informations/astronautes/astronaute");
            foreach (XmlNode node in nl)
            {
                String astronaute;
                XmlAttribute xml_attr = node.Attributes["nom"];
                astronaute=xml_attr.Value;

                _astronautes.Add(astronaute);
            }
            _nbAstraunautes = _astronautes.Count(); 
        }

        private void load_journeeDefaut(XmlDocument doc)
        {
            _journeeDefaut = new ClassJour();

        }



    }
}
