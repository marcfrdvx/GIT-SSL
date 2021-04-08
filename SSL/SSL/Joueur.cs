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
        //autoscale
        public float newWidth;
        public float newHeight;
        public float originalWidth = 1280;
        public float originalHeight = 720;
        public Point btnDeleteAllPlayerOldLocation;
        public Point tbxAddPlayerOldLocation;
        public Point picBoxAddPlayerOldLocation;
        public Point flowPanelJoueurOldLocation;
        public Size picBoxAddPlayerSize;


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
            //autoscale
            btnDeleteAllPlayerOldLocation = btnDeleteAllPlayer.Location;
            tbxAddPlayerOldLocation = tbxAddPlayer.Location;
            picBoxAddPlayerOldLocation = picBoxAddPlayer.Location;
            flowPanelJoueurOldLocation = flowPanelJoueur.Location;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            RefToMain.Show();
            this.Close();
        }

        private void picBoxAddPlayer_Click(object sender, EventArgs e)
        {
            bool ajouterNouveauJoueur = true;

            if (Player.listPlayer.Count > 0)
            {
                //Si le joueur n'existe pas déjà, le stock dans la liste de joueurs
                foreach (var Player in Player.listPlayer)
                {
                    if (tbxAddPlayer.Text == Player.Nom)
                    {
                        MessageBox.Show("Ce joueur existe déjà, veuillez entrer un autre nom pour ce joueur", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ajouterNouveauJoueur = false;
                    }                    
                }

                if (ajouterNouveauJoueur==true)
                {
                    AjouterJoueur();              
                }
            }
            else
            {
                AjouterJoueur();
            }

            //Focus la tbx pour ajouter un autre joueur à la suite
            tbxAddPlayer.Focus();
            tbxAddPlayer.SelectAll();
        }

        private void btnDeleteAllPlayer_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Etes-vous sûr de vouloir supprimer tous les joueurs ?", "Attention cette action est irréversible !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                //Supprime tous les joueurs (objet + liste)
                Player.listPlayer.Clear();
                flowPanelJoueur.Controls.Clear();
            }
        }

        private void Joueur_Load(object sender, EventArgs e)
        {
            //affiche les joueurs existants au chargement de la page
            if (Player.listPlayer.Count != 0)
            {
                foreach (var Player in Player.listPlayer)
                {
                    Label lbl = new Label();
                    lbl.Text = Player.ToString();
                    lbl.AutoSize = true;
                    flowPanelJoueur.Controls.Add(lbl);
                }
            }
            //Active placeholder pour tbxAddPlayer quand on quitte la textbox        
            tbxAddPlayer.Text = "Ajouter un joueur";
            tbxAddPlayer.Font = new Font(tbxAddPlayer.Font, FontStyle.Italic);
            tbxAddPlayer.ForeColor = System.Drawing.SystemColors.ScrollBar;


            //pour autoscale
            newWidth = this.Width;
            newHeight = this.Height;
            ResizeControls();
            picBoxAddPlayerSize = picBoxAddPlayer.Size;

        }

        private void tbxAddPlayer_Click(object sender, EventArgs e)
        {
            //Désactive placeholder pour tbxAddPlayer quand on ajoute un nouveau joueur
            tbxAddPlayer.Text = "";
            tbxAddPlayer.ForeColor = System.Drawing.SystemColors.MenuText;
            tbxAddPlayer.Font = new Font(tbxAddPlayer.Font, FontStyle.Regular);
        }

        private void picBoxAddPlayer_MouseEnter(object sender, EventArgs e)
        {
            picBoxAddPlayer.Size = new Size(picBoxAddPlayer.Width * 125 / 100, picBoxAddPlayer.Height * 125 / 100);
        }

        private void picBoxAddPlayer_MouseLeave(object sender, EventArgs e)
        {
            picBoxAddPlayer.Size = picBoxAddPlayerSize;
        }

        private void tbxAddPlayer_Leave(object sender, EventArgs e)
        {
            //Active placeholder pour tbxAddPlayer quand on quitte la textbox        
            tbxAddPlayer.Text = "Ajouter un joueur";
            tbxAddPlayer.Font = new Font(tbxAddPlayer.Font, FontStyle.Italic);
            tbxAddPlayer.ForeColor = System.Drawing.SystemColors.ScrollBar;
        }

        private void tbxAddPlayer_KeyDown(object sender, KeyEventArgs e)
        {
            //Check si la touche pressée est "Enter"            
            if (e.KeyCode == Keys.Enter)
            {
                picBoxAddPlayer_Click(sender, e);
                //empêche le bip de Windows quand on presse sur la touche Entre dans la textbox
                e.Handled = e.Handled = e.SuppressKeyPress = true;
            }

        }
        private void AjouterJoueur()
        {
            if (tbxAddPlayer.Text != "")
            {
                //Créer le joueur
                Player j = new Player(tbxAddPlayer.Text);

                Player.listPlayer.Add(j);
                //supprime l'affichage du tableau
                flowPanelJoueur.Controls.Clear();
                //affiche chaque joueur dans le tableau
                foreach (var Player2 in Player.listPlayer)
                {
                    Label lbl = new Label();
                    lbl.Text = Player2.ToString();
                    lbl.AutoSize = true;
                    flowPanelJoueur.Controls.Add(lbl);
                }
            }
            else
            {
                MessageBox.Show("Nom du joueur invalide", "Le nom du joueur ne peut pas être vide", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tbxAddPlayer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void ResizeControls()
        {
            float scaleFactorWidth = originalWidth / newWidth;
            float scaleFactorHeight = originalHeight / newHeight;
            Control.ControlCollection controlCollection = this.Controls;

            foreach (Control item in controlCollection)
            {
                //Point oldLocation = item.Location;
                //if (item.GetType() == typeof(Button)){}                
                item.Size = new Size(Convert.ToInt32(item.Size.Width / scaleFactorWidth), Convert.ToInt32(item.Size.Height / scaleFactorHeight));
                item.Font = new Font(item.Font.FontFamily, item.Font.Size / scaleFactorHeight);
            }
            //btnQuitter.Left = Convert.ToInt32(newWidth - btnQuitter.Width - 25);
            picBoxLogo.Location = new Point((this.Width - picBoxLogo.Width) / 2, Convert.ToInt32(50 / scaleFactorHeight));
            lblListeJoueur.Location = new Point((this.Width - lblListeJoueur.Width) / 2, Convert.ToInt32(300 / scaleFactorHeight));
            btnDeleteAllPlayer.Location = new Point(Convert.ToInt32(btnDeleteAllPlayerOldLocation.X / scaleFactorHeight), Convert.ToInt32(btnDeleteAllPlayerOldLocation.Y / scaleFactorHeight));
            tbxAddPlayer.Location = new Point(Convert.ToInt32(tbxAddPlayerOldLocation.X / scaleFactorHeight), Convert.ToInt32(tbxAddPlayerOldLocation.Y / scaleFactorHeight));
            picBoxAddPlayer.Location = new Point(Convert.ToInt32(picBoxAddPlayerOldLocation.X / scaleFactorHeight), Convert.ToInt32(picBoxAddPlayerOldLocation.Y / scaleFactorHeight));
            flowPanelJoueur.Location = new Point(Convert.ToInt32(flowPanelJoueurOldLocation.X / scaleFactorHeight), Convert.ToInt32(flowPanelJoueurOldLocation.Y / scaleFactorHeight));

            //btnJouer.Location = new Point(Convert.ToInt32(btnJouerOldLocation.X / scaleFactorHeight), Convert.ToInt32(btnJouerOldLocation.Y / scaleFactorHeight));
            //btnScore.Location = new Point(Convert.ToInt32(btnScoreOldLocation.X / scaleFactorHeight), Convert.ToInt32(btnScoreOldLocation.Y / scaleFactorHeight));
        }

    }
}