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
    public partial class Jouer : Form
    {
        private Menu RefToMain;

        public Jouer(Menu frm)
        {
            RefToMain = frm;
            InitializeComponent();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            RefToMain.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CultureGenerale frmCG = new CultureGenerale(this);
            frmCG.Show();
            this.Hide();
        }
    }
}
