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
    public partial class Joueur : Form
    {
        /// <summary>
        /// La forme de référence principale
        /// </summary>
        private Menu RefToMain;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="frm">La forme principale a afficher lors de la fermeture de celle-ci</param>
        public Joueur(Menu frm)
        {
            RefToMain = frm;
            InitializeComponent();
            

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            RefToMain.Show();
            this.Close();
        }

        private void picBoxAddPlayer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Joueur ajouté : "+ tbxAddPlayer.Text);

            var player = new List<string>();
            player.Add(tbxAddPlayer.Text);

            foreach (var item in player)
            {
                Label lbl = new Label();
                lbl.Text = item.ToString();
                splitContainerJoueur.Panel1.Controls.Add(lbl);
            }


        }

        private void picBoxAddPlayer_MouseMove(object sender, MouseEventArgs e)
        {
            picBoxAddPlayer.BackColor = Color.White;
        }
    }
}
