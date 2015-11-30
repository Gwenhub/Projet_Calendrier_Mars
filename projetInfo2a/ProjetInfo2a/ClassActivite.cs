using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetInfo2a
{
    class ClassActivite
    {
        private double heureDebut
        {
            get;
            set;
        }

        private double heureFin
        {
            get;
            set;
        }

        private List<String> Astronautes
        {
            get;
            set;
        }

        private string Descriptif
        {
            get;
            set;
        }

        /// <summary>
        /// valeur prise dans la List Activités de Mission
        /// </summary>
        private string Categorie
        {
            get;
            set;
        }

        private bool SortieExt
        {
            get;
            set;
        }

        public ClassLieu Lieu
        {
            get;
            set;
        }

        public virtual Jour Date
        {
            get;
            set;
        }

        public String getCategorie() { return Categorie; }
        public void setCategorie( string newCat) { }

        public virtual void getSortieExt()
        {
            throw new System.NotImplementedException();
        }

        public virtual void setSortieExt()
        {
            throw new System.NotImplementedException();
        }

        public virtual List<String> getAstronautes()
        {
            throw new System.NotImplementedException();
        }

        public virtual double getHeureDeb()
        {
            throw new System.NotImplementedException();
        }

        public virtual double getHeureFin()
        {
            throw new System.NotImplementedException();
        }

        public virtual void setHeureDeb(double newHdeb)
        {
            throw new System.NotImplementedException();
        }

        public virtual void setHeureFin(double newHfin)
        {
            throw new System.NotImplementedException();
        }
    }
}
