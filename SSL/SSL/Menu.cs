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
        public List<Player> listPlayer;

        //autoscale
        public float newWidth;
        public float newHeight;
        public float originalWidth = 1280;
        public float originalHeight = 720;
        public Point btnJoueurOldLocation;
        public Point btnJouerOldLocation;
        public Point btnScoreOldLocation;

        public Menu()
        {
            InitializeComponent();
            //autoscale
            btnJoueurOldLocation = btnJoueur.Location;
            btnJouerOldLocation = btnJouer.Location;
            btnScoreOldLocation = btnScore.Location;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            //Demande une confirmation avant de quitter l'application complètement
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir quitter l'application ?", "Quitter ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                //Environment.Exit(0);
                System.Windows.Forms.Application.ExitThread();
            }
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

        private void btnScore_Click(object sender, EventArgs e)
        {
            Score frmScore = new Score(this);
            frmScore.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            newWidth = this.Width;
            newHeight = this.Height;
            ResizeControls();
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
            btnQuitter.Left = Convert.ToInt32(newWidth - btnQuitter.Width - 25);
            picBoxLogo.Location = new Point((this.Width - picBoxLogo.Width) / 2, Convert.ToInt32(50 / scaleFactorHeight));
            btnJoueur.Location = new Point(Convert.ToInt32(btnJoueurOldLocation.X / scaleFactorHeight), Convert.ToInt32(btnJoueurOldLocation.Y / scaleFactorHeight));
            btnJouer.Location = new Point(Convert.ToInt32(btnJouerOldLocation.X / scaleFactorHeight), Convert.ToInt32(btnJouerOldLocation.Y / scaleFactorHeight));
            btnScore.Location = new Point(Convert.ToInt32(btnScoreOldLocation.X / scaleFactorHeight), Convert.ToInt32(btnScoreOldLocation.Y / scaleFactorHeight));
        }
    }
}
