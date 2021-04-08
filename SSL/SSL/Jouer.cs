using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace SSL
{
    public partial class Jouer : Form
    {
        //autoscale
        public float newWidth;
        public float newHeight;
        public float originalWidth = 1280;
        public float originalHeight = 720;
        public Point picBoxCGOldLocation;
        public Point lblTraitOldLocation;
        public Point lblCGOldLocation;


        private Menu RefToMain;

        public Question[][] Questions;
        public string path = "..\\..\\Resources\\data.json";


        public Jouer(Menu frm)
        {
            RefToMain = frm;
            InitializeComponent();
            //autoscale
            picBoxCGOldLocation = picBoxCG.Location;
            lblTraitOldLocation = lblTrait.Location;
            lblCGOldLocation = lblCG.Location;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            RefToMain.Show();
            this.Close();
        }

        private void picBoxCG_Click(object sender, EventArgs e)
        {
            //s'il n'y a aucun jouer de créé
            if (Player.listPlayer.Count <= 0)
            {
                MessageBox.Show("Il n'y a aucun joueur créé, vous allez être redirigé vers la page de création de joueur","Attention ! ",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                Joueur frmJoueur = new Joueur(RefToMain);
                frmJoueur.Show();
                this.Hide();
            }
            else
            {
                CultureGenerale frmCG = new CultureGenerale(this);
                frmCG.Show();
                this.Hide();
            }
        }

        private void Jouer_Load(object sender, EventArgs e)
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
            //btnQuitter.Left = Convert.ToInt32(newWidth - btnQuitter.Width - 25);
            //picBoxLogo.Location = new Point((this.Width - picBoxLogo.Width) / 2, Convert.ToInt32(50 / scaleFactorHeight));
            //btnJoueur.Location = new Point(Convert.ToInt32(btnJoueurOldLocation.X / scaleFactorHeight), Convert.ToInt32(btnJoueurOldLocation.Y / scaleFactorHeight));
            //btnJouer.Location = new Point(Convert.ToInt32(btnJouerOldLocation.X / scaleFactorHeight), Convert.ToInt32(btnJouerOldLocation.Y / scaleFactorHeight));
            picBoxCG.Location = new Point(Convert.ToInt32(picBoxCGOldLocation.X / scaleFactorHeight), Convert.ToInt32(picBoxCGOldLocation.Y / scaleFactorHeight));
            lblTrait.Location = new Point(Convert.ToInt32(lblTraitOldLocation.X / scaleFactorHeight), Convert.ToInt32(lblTraitOldLocation.Y / scaleFactorHeight));
            lblCG.Location = new Point(Convert.ToInt32(lblCGOldLocation.X / scaleFactorHeight), Convert.ToInt32(lblCGOldLocation.Y / scaleFactorHeight));
        }

    }
}
