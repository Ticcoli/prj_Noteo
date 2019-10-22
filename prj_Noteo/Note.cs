using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_Noteo
{
    class Note
    {
        //attribut privé
        private float coef;
        private float note;

        //cosntructeur
        public Note(float leCoef, float laNote)
        {
            this.note = laNote;
            this.coef = leCoef;
        }

        //setter
        public void setNote(float laNouvelleNote){ this.note = laNouvelleNote; }

        public void setCoef(float leNouveauCoef) { this.coef = leNouveauCoef; }

        //accesseur

        public float getNote() { return this.note; }

        public float getCoef() { return this.coef;  }


    }
}
