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
    public partial class Score : Form
    {
        //autoscale
        public float newWidth;
        public float newHeight;
        public float originalWidth = 1280;
        public float originalHeight = 720;
        public Point tblScoreOldLocation;


        private Menu RefToMain;

        public Score(Menu frm)
        {
            RefToMain = frm;
            InitializeComponent();
            //autoscale
            tblScoreOldLocation = tblScore.Location;

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            RefToMain.Show();
            this.Close();
        }

        private void Score_Load(object sender, EventArgs e)
        {
            newWidth = this.Width;
            newHeight = this.Height;
            ResizeControls();


            //Affiche le tableau des scores
            Afficherscore();
        }

        private void btnResetScore_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Etes-vous sûr de vouloir remettre à zéro tous les scores ?", "Attention cette action est irréversible !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                //Reset les score de tous les joueurs
                foreach (var Player in Player.listPlayer)
                {
                    Player.Score = 0;
                }

                //Remet à zéro le tableau des scores, ferme la page et ouvre une nouvelle
                Menu menu = new Menu();
                Score score = new Score(menu);
                score.Show();
                this.Hide();
            }
        }

        private void Afficherscore()
        {
            //Créer autant de ligne que de joueur
            tblScore.RowCount = Player.listPlayer.Count;

            //Place les joueurs en fonction de leur score dans la liste
            Player.listPlayer.Sort(delegate(Player j1, Player j2){
                return j2.Score.CompareTo(j1.Score);
            });

            //génère l'affichage
            for (int i = 1; i <= tblScore.RowCount; i++)
            {
                tblScore.Controls.Add(new Label() { Text = Convert.ToString(i) }, 0, i - 1);
                tblScore.Controls.Add(new Label() { Text = Player.listPlayer[i - 1].Nom }, 1, i - 1);
                tblScore.Controls.Add(new Label() { Text = Convert.ToString(Player.listPlayer[i - 1].Score) }, 2, i - 1);
            }
        }


        //en test pour repeindre les 3 premières case pour le classement
        private void tblScore_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            /*
             * Doit être implémenté ultérieurement
             */

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
            btnResetScore.Left = Convert.ToInt32(newWidth - btnResetScore.Width - 25);
            picBoxTrophy.Location = new Point((this.Width - picBoxTrophy.Width) / 2, Convert.ToInt32(50 / scaleFactorHeight));
            tblScore.Location = new Point(Convert.ToInt32(tblScoreOldLocation.X / scaleFactorHeight), Convert.ToInt32(tblScoreOldLocation.Y / scaleFactorHeight));

            TableLayoutColumnStyleCollection tblScoreColumns = tblScore.ColumnStyles;

            tblScoreColumns[0].SizeType = SizeType.Absolute;
            tblScoreColumns[1].SizeType = SizeType.Absolute;
            tblScoreColumns[2].SizeType = SizeType.Absolute;
            tblScoreColumns[0].Width = tblScore.Width * 10 / 100;
            tblScoreColumns[1].Width = tblScore.Width * 70 / 100;
            tblScoreColumns[2].Width = tblScore.Width * 20 / 100;


        }

    }
}
