using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSL
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            //Demande une confirmation avant de quitter l'application complètement
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir quitter l'application ?", "Quitter ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //fonction de test pour le background
            this.Hide();
        }

        private void btnJoueur_Click(object sender, EventArgs e)
        {
            Joueur frmJoueur = new Joueur(this);
            frmJoueur.Show();
            this.Hide();
        }

        private void btnJouer_Click(object sender, EventArgs e)
        {
            Jouer frmJouer = new Jouer(this);
            frmJouer.Show();
            this.Hide();
        }
    }
}
