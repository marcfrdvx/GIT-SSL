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
        private Menu RefToMain;

        public Question[][] Questions;
        public string path = "..\\..\\Resources\\data.json";


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

        //bouton test
        private void btnGetQuestion_Click(object sender, EventArgs e)
        {
            string jsonData = "";
            using (StreamReader strReader = new StreamReader(path))
            {
                jsonData = strReader.ReadToEnd();
            }

            Question[][] mesQuestions = JsonConvert.DeserializeObject<Question[][]>(jsonData);

            rtbxQuestions.AppendText(mesQuestions.Length + mesQuestions.ToString());           
        }

        private void picBoxCG_Click(object sender, EventArgs e)
        {
            //s'il n'y a aucun jouer de créé
            if (Player.listPlayer.Count <= 0)
            {
                MessageBox.Show("Il n'y a aucun joueur créé, vous allez être redirigé vers la page de création de joueur");
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
    }
}
