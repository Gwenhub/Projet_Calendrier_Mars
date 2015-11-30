using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetInfo2a
{
    class ClassCompteRendu
    {
        private string _titre;
        private string _contenu;
        private static int _nbCaractMax;
        public Jour _date;

        public void setContenu(String newContenu)
        {
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
    }
}
