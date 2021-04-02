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
            //Créer autant de ligne que de joueur
            tblScore.RowCount = Player.listPlayer.Count;

            //gère l'affichage et la création de nouvelle ligne
            for (int i = 1; i <= tblScore.RowCount; i++)
            {
                tblScore.Controls.Add(new Label() { Text = Convert.ToString(i) }, 0, i-1);
                tblScore.Controls.Add(new Label() { Text = Player.listPlayer[i - 1].Nom }, 1, i - 1);
                tblScore.Controls.Add(new Label() { Text = Convert.ToString(Player.listPlayer[i - 1].Score) }, 2, i - 1);
            }

            // ATTENTION IL FAUT TRIER LES JOUEURS DANS L'ORDRE DU SCORE !!!
        }
    }
}
