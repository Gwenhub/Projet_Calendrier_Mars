using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetInfo2a
{
    class ClassActivite
    {
        private double _heureDebut;
        private double _heureFin;
        private List<String> _astronautes;
        private string _descriptif;
        private string _categorie;
        private bool _sortieExt;
        public ClassLieu _lieu;
        public ClassJour _date; 
        
        public String getCategorie()
        {
            return _categorie;
        }
        public void setCategorie( string newCat)
        {
            _categorie = newCat;
        }

        public bool getSortieExt()
        {
            return _sortieExt;
        }

        public void setSortieExt(bool newSortie)
        {
            _sortieExt = newSortie;
        }

        public List<String> getAstronautes()
        {
            return _astronautes;
        }

        public double getHeureDeb()
        {
            return _heureDebut;
        }

        public double getHeureFin()
        {
            return _heureFin;
        }

        public void setHeureDeb(double newHdeb)
        {
            _heureDebut = newHdeb;
        }

        public void setHeureFin(double newHfin)
        {
            _heureFin = newHfin;
        }
    }
}
