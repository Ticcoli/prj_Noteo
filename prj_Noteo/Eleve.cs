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
        List<Matiere> lesMatieres;

        //cosntructeur
        public Eleve(int lId, string leNom, string lePrenom, string leMdp)
        {
            this.idEleve = lId;
            this.nomEleve = leNom;
            this.prenomEleve = lePrenom;
            this.passwordEleve = leMdp;
            this.lesMatieres = new List<Matiere>() ;
        }

        //setter
        public void setId(int lID)
        {
            this.idEleve = lID;
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

        public List<Note> getTouteLesNotes()
        {
            List<Note> TotNote = new List<Note>();
            foreach (Matiere laMatiere in lesMatieres)
            {
                foreach (Note laNote in laMatiere.getLesNote())
                {
                    TotNote.Add(laNote);
                }
            }
            return TotNote;
        }
    }
}