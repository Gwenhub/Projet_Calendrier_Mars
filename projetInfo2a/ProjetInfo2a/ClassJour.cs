using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetInfo2a
{
    class ClassJour
    {
        private int numero
        {
            get;
            set;
        }

        /// <summary>
        /// passé/prst/futur
        /// </summary>
        private string statut
        {
            get;
            set;
        }

        public virtual IEnumerable<Activite> Activites
        {
            get;
            set;
        }

        public virtual ClassCompteRendu CompteRendu
        {
            get;
            set;
        }



        public virtual ClassMission Mission
        {
            get;
            set;
        }

        public virtual bool sortieExte()
        {
            throw new System.NotImplementedException();
        }

        public virtual void ajouterActivite(ClassActivite act)
        {
            throw new System.NotImplementedException();
        }

        public virtual void supprActivite()
        {
            throw new System.NotImplementedException();
        }

        public virtual void modifAcitivite()
        {
            throw new System.NotImplementedException();
        }

        public virtual void setStatut()
        {
            throw new System.NotImplementedException();
        }

        public virtual void getStatut()
        {
            throw new System.NotImplementedException();
        }

        public virtual void ajouterCR()
        {
            throw new System.NotImplementedException();
        }
    }
}
