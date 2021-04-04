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
        private Menu RefToMain;

        public Score(Menu frm)
        {
            RefToMain = frm;
            InitializeComponent();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            RefToMain.Show();
            this.Close();
        }

        private void Score_Load(object sender, EventArgs e)
        {
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
            
        }
    }
}
