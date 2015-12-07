using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetInfo2a
{
    public class ClassCompteRendu
    {
        private string _titre;
        private string _contenu;
        private static int _nbCaractMax;
        public ClassJour _date;

        public ClassCompteRendu()
        {
            _nbCaractMax = 1000;
        }

        public void setContenu(String newContenu)
        {
            if (newContenu.Length<=_nbCaractMax)
            _contenu = newContenu;
        }

        public string getContenu()
        {
            return _contenu;
        }

        public string getTitre()
        {
            return _titre;
        }

        public void setTitre(String newTitre)
        {
            _titre = newTitre;
        }

        public void setDate(ClassJour newDate)
        {
            _date = newDate;
        }
        public ClassJour getDate()
        {
            return _date;
        }
    }
}
