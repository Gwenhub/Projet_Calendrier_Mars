using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetInfo2a
{
    class ClassLieu
    {
        private String _carte;
        private int _echelleMpx;
        private String _nom;
        private double[,] _position; //coordonnées x,y du lieu sur la carte de la zone


        public virtual void setPosition(double x, double y)
        {
            throw new System.NotImplementedException();
        }

        public virtual double[,] getPosition()
        {
            throw new System.NotImplementedException();
        }

        public virtual string getNom()
        {
            throw new System.NotImplementedException();
        }

        public virtual void setNom(String newNom)
        {
            throw new System.NotImplementedException();
        }

        public virtual string getCarte()
        {
            throw new System.NotImplementedException();
        }

        public virtual void setCarte(String newCarte)
        {
            throw new System.NotImplementedException();
        }

        public virtual string getEchelle()
        {
            throw new System.NotImplementedException();
        }

        public virtual void setEchelle(int newEchelle)
        {
            throw new System.NotImplementedException();
        }
    }
}
