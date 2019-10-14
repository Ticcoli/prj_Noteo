using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_Noteo
{
    class Matiere
    {
        //attribut privé
        private int idMatiere;
        private string libMatiere;
        private string NomprofMatiere;
        private List<Note> lesNotes;

        //cosntructeur
        public Matiere(int lIdMatiere, string leLib, string leNomProfMatiere)
        {
            this.idMatiere = lIdMatiere;
            this.libMatiere = leLib;
            this.NomprofMatiere = leNomProfMatiere;
            this.lesNotes = new List<Note>();
        }

        //setter
        public void setIdMatiere(int id)
        {
            this.idMatiere = id;
        }

        public void setLibMatiere(string lib)
        {
            this.libMatiere = lib;
        }

        public void setNomProf(string nomProf)
        {
            this.NomprofMatiere = nomProf;
        }

        //accesseur

        public int getId()
        {
            return this.idMatiere;
        }

        public string getLibMatiere()
        {
            return this.libMatiere;
        }

        public string getNomProf()
        {
            return this.NomprofMatiere;
        }

    }
}
