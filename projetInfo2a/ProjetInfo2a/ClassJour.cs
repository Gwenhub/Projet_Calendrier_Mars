using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetInfo2a
{
    class ClassJour
    {
        private int _numero;
        private string _statut; // passé/prst/futur
        public Dictionary<double[,], Activite> _activites;
        public ClassCompteRendu _compteRendu;
        public ClassMission _mission;

        public bool getSortieExte()
        {
            // return true ssi une des activités de _activites return true aussi
            return false;
        }

        public void ajouterActivite(ClassActivite act)
        {
            /*
            insere une entrée dans le dictionnaire _activites :
            value = activite, key=[activite.hDeb, activite.hFin]
            */
        }

        public void supprActivite()
        {
            throw new System.NotImplementedException();
        }

        public void modifAcitivite()
        {
            throw new System.NotImplementedException();
        }

        public void setStatut(String newStatut)
        {
            _statut = newStatut;
        }

        public String getStatut()
        {
            return _statut;
        }

        public void setCR(ClassCompteRendu CR)
        {
            _compteRendu = CR;
        }
    }
}
