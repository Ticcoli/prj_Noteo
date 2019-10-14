using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj_Noteo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //chargement des données de la base BD_ProSante_V1 dans les collections
            // --> lesVisiteurs
            Globale.lesEleves = new Dictionary<int, Eleve>();

            string chaineDeconnexion = "SERVER=localhost;" + "DATABASE=bulletin;" + "UID=root;" + "PASSWORD=;";
            MySqlConnection connection = new MySqlConnection(chaineDeconnexion);
            MySqlCommand maCommande = connection.CreateCommand();
            MySqlDataReader maLigne;
            maCommande.CommandText = "INSERT INTO `bulletin`.`eleve` (`ideleve`, `nom`, `prenom`, `classe`, `password`) VALUES ('4', 'tbprenom.text', 'Grégoire', 'BTS1', MD5('')); ";
            connection.Open();
            maLigne = maCommande.ExecuteReader();
            while (maLigne.Read())
            {
                string[] valeurColonnes = new string[5];
                for (int i = 0; i < maLigne.FieldCount; i++) valeurColonnes[i] = maLigne.GetValue(i).ToString();

                string matricule = valeurColonnes[0];
                string nom = valeurColonnes[1];
                string prenom = valeurColonnes[2];
                string numTel = valeurColonnes[3];
                string Secteur = valeurColonnes[4];

                visiteur unVisiteur = new visiteur(matricule, nom, prenom, int.Parse(numTel), Secteur);
                Globale.lesVisiteurs.Add(unVisiteur);
            }
            connection.Close();

           
        }
    }
}
