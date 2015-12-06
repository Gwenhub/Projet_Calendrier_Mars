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
        private double[] _position; //coordonnées x,y du lieu sur la carte de la zone

        public ClassLieu()
        {
            _position = new double[2];
        }

        public void setPosition(double x, double y)
        {
            _position[0] = x;
            _position[1] = y;
        }

        public double[] getPosition()
        {
            return _position;
        }

        public string getNom()
        {
            return _nom;
        }

        public void setNom(String newNom)
        {
            _nom = newNom;
        }

        public string getCarte()
        {
            return _carte;
        }

        public void setCarte(String newCarte)
        {
            _carte = newCarte;
        }

        public int getEchelle()
        {
            return _echelleMpx;
        }

        public void setEchelle(int newEchelle)
        {
            _echelleMpx = newEchelle;
        }
    }
}
