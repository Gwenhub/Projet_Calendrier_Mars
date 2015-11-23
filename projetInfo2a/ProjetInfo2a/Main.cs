using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml;

namespace ProjetInfo2a
{
    class Main
    {
        public void recupXML()
        {
            XmlDocument xmlDoc = new XmlDocument();

            try
            {
                xmlDoc.Load("infosGenerales.xml"); //dans le bin/debug
            }
            catch
            {
                string message = "Aucun fichier de sauvegarde n'a été trouvé.";
                MessageBox.Show(message);
                return;
            }

            XmlNodeList nodeListInfo = xmlDoc.GetElementsByTagName("informations");

            foreach (XmlNode node in nodeListInfo)
            {

            }
        }
    }
}
