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
    public partial class Inscription : Form
    {
        public Inscription()
        {
            InitializeComponent();
        }

        public void VerifVide()
        {
            if (tbPrenom.Text == "" || tbNom.Text == "" || tbMdp.Text == "" || string.IsNullOrEmpty(cbClasse.Text))
            {
                btConnexion.Enabled = false;
            }
            else
            {
                btConnexion.Enabled = true;
            }
        }
        private void Inscription_Load(object sender, EventArgs e)
        {
            VerifVide();
        }
        private void btConnexion_Click(object sender, EventArgs e)
        {

        }

        private void tbPrenom_TextChanged(object sender, EventArgs e)
        {
            VerifVide();
        }

        private void tbNom_TextChanged(object sender, EventArgs e)
        {
            VerifVide();
        }

        private void tbMdp_TextChanged(object sender, EventArgs e)
        {
            VerifVide();
        }

        private void cbClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerifVide();
        }
    }
}
