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
        public Dictionary<double[], ClassActivite> _activites;
        public ClassCompteRendu _compteRendu;
        public ClassMission _mission;

        public bool getSortieExte()
        {
            // return true ssi une des activités de _activites return true aussi
            foreach(ClassActivite act in _activites.Values)
            {
                if (act.getSortieExt())
                    return true;
            }
            return false;
        }

        // insere une activité au dico et lui donne pr clef son couple hDebut, hFin
        public void ajouterActivite(ClassActivite act)
        {
            double hDeb =act.getHeureDeb();
            double hFin = act.getHeureFin();
            double[] creneau = new double[] { hDeb, hFin };
            _activites.Add(creneau, act);
        }

        public void supprActivite(double[] crenau)
        {
            //remove <key,value> where key==creneau
            _activites.Remove(crenau);
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

        public void defineStatut()
        {
            int diff = _numero - _mission.getJourJ();

            switch (Math.Sign(diff)) {
                case -1:
                    setStatut("passé");
                     break;
                case  0:
                    setStatut("present");
                     break;
                case 1:
                    setStatut("futur");                    
                    break;
            }

        }
    }
}
