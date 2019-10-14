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

        public void setPasswordEleve(string leMdp)
        {
            this.passwordEleve = leMdp;
        }

        //accesseur
        public int getIdEleve() {   return this.idEleve;    }

        public string getNomEleve() { return this.nomEleve; }

        public string getPrenomEleve() { return this.prenomEleve; }

        public string getMdpEleve() { return this.passwordEleve; }

    }
}