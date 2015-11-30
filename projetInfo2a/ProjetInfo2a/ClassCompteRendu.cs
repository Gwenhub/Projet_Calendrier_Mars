using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetInfo2a
{
    class ClassCompteRendu
    {
        private string titre
        {
            get;
            set;
        }

        private string contenu
        {
            get;
            set;
        }

        private static int nbCaractMax
        {
            get;
            set;
        }

        public virtual Jour Date
        {
            get;
            set;
        }

        public virtual void setCR(String newCR)
        {
            throw new System.NotImplementedException();
        }

        public virtual string getCR()
        {
            throw new System.NotImplementedException();
        }

        public virtual string getTitre()
        {
            throw new System.NotImplementedException();
        }

        public virtual void setTitre(String newTitre)
        {
            throw new System.NotImplementedException();
        }
    }
}
