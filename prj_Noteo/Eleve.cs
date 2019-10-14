using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_Noteo
{
    class Eleve
    {
        //attribut privé
        private int idEleve;
        private string nomEleve;
        private string prenomEleve;
        private string passwordEleve;

        //cosntructeur
        public Eleve(int lId, string leNom, string lePrenom, string leMdp)
        {
            this.idEleve = lId;
            this.nomEleve = leNom;
            this.prenomEleve = lePrenom;
            this.passwordEleve = leMdp;
        }

        //setter
        public void setId()
        {

        }

        public void setNomEleve(string leNom)
        {
            this.nomEleve = leNom;
        }

        public void setPrenomEleve(string lePrenom)
        {
            this.prenomEleve = lePrenom;
        }

        //accesseur


    }
}