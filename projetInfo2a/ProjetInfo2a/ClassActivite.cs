using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetInfo2a
{
    public class ClassActivite
    {
        private double _heureDebut;
        private double _heureFin;
        private List<string> _astronautes;
        private string _descriptif;
        private string _categorie;
        private bool _sortieExt;
        public ClassLieu _lieu;
        public ClassJour _date; 

        public ClassActivite()
        {
            _astronautes = new List<string>();
        }
        /*
        public ClassActivite(string participant)
        {
            _astronautes = new List<string>();
            _astronautes.Add(participant);
        }
        */

       public void setDescriptif(string newDescriptif)
        {
            _descriptif = newDescriptif;
        }
        public string getDescriptif()
        {
            return _descriptif;
        }

        public void setAstronautes(List<string> newAstronautes)
        {
            _astronautes = newAstronautes;
        }
        public List<string> getAstronautes()
        {
            return _astronautes;
        }

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

        public ClassJour getDate()
        {
            return _date;
        }
        public void setDate(ClassJour newDate)
        {
            _date = newDate;
        }

        public ClassLieu getLieu()
        {
            return _lieu;
        }
        public void setLieu(ClassLieu newLieu)
        {
            _lieu=newLieu;
        }

        public void ajoutAstronaute(string astronaute)
        {
            _astronautes.Add(astronaute);
        }

        public void supprAstronaute(string astronaute)
        {
            _astronautes.Remove(astronaute);
        }
    }
}
