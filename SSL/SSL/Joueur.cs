﻿using System;
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
        public List<Player> listPlayer = new List<Player>();
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
            //Créer le joueur
            Player j = new Player(tbxAddPlayer.Text);
            //Le stock dans la liste de joueurs
            listPlayer.Add(j);

            //supprime l'affichage du tableau
            flowPanelJoueur.Controls.Clear();
            //affiche chaque joueur dans le tableau
            foreach (var Player in listPlayer)
            {
                Label lbl = new Label();
                lbl.Text = Player.ToString();
                lbl.AutoSize = true;
                flowPanelJoueur.Controls.Add(lbl);
            }
        }

        private void picBoxAddPlayer_MouseMove(object sender, MouseEventArgs e)
        {
            picBoxAddPlayer.BackColor = Color.White;
        }

        private void btnDeleteAllPlayer_Click(object sender, EventArgs e)
        {
            //Supprime tous les joueurs (objet + liste)
            listPlayer.Clear();
            flowPanelJoueur.Controls.Clear();
        }
    }
}
