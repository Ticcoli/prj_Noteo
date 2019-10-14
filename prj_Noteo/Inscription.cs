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

        private void Inscription_Load(object sender, EventArgs e)
        {
            if (tbPrenom.Text != "" || tbNom.Text != "" || tbMdp.Text != "" || cbClasse.Text != "")
            {
                btConnexion.Enabled = false;
            }
            else
            {

            }
        }
        private void btConnexion_Click(object sender, EventArgs e)
        {

        }
    }
}
