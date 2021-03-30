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
    public partial class CultureGenerale : Form
    {
        //directory des ressources pour JSON
        public string path = "..\\..\\Resources\\Questions.json";

        List<string> questionnaire = new List<string>();

        private Jouer RefToJouer;
        private string[,] question = new string[2, 6] { { "question1", "rep1a", "rep1bjuste", "rep1c", "rep1d", "2" }, { "question2", "rep2ajuste", "rep2b", "rep2c", "rep2d", "1" } };
        private int numQuestion = 0;
        public CultureGenerale(Jouer frm)
        {
            RefToJouer = frm;
            InitializeComponent();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            RefToJouer.Show();
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            NextQuestion();
            btnStart.Visible = false;            
        }

        private void picBoxRight_Click(object sender, EventArgs e)
        {
            NextQuestion();
            picBoxRight.Visible = false;
        }

        private void NextQuestion()
        {
            if (numQuestion >= question.GetLength(0))
            {
                picBoxRight.Visible = false;
                MessageBox.Show("Il n'y a plus de nouvelle question. Vous allez être redirigé vers la page des scores...", "Toute bonne chose à une fin...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lblQuestion.Text = question[numQuestion, 0];
                var lblReponse = new List<Label>() { lblRep1, lblRep2, lblRep3, lblRep4 };
                for (int i = 1; i <= 4; i++)
                {
                    lblReponse[i - 1].Text = question[numQuestion, i];
                    lblReponse[i - 1].ForeColor = Color.Black;
                }
                int bonneReponse = Convert.ToInt32(question[numQuestion, 5]);
                lblReponse[bonneReponse - 1].ForeColor = Color.Green;
                numQuestion++;
            }           
        }

        private void ShowDuo()
        {
            int bonneReponse = Convert.ToInt32(question[numQuestion, 5]);
            Random pair = new Random();
            int test = Convert.ToInt32(pair.Next(0, 1001));
            if (test % 2 == 0) //test si le chiffre est pair
            {
                //rendre aléatoire l'affiche des réponses quand on a deux choix...
            }

        }

        private void btnRepCarre_Click(object sender, EventArgs e)
        {
            tblCarre.Visible = true;
            btnRepCarre.Visible = false;
        }

        private void btnRepDuo_Click(object sender, EventArgs e)
        {
            tblDuo.Visible = true;
            btnRepDuo.Visible = false;
            ShowDuo();            
        }

        private void CultureGenerale_Load(object sender, EventArgs e)
        {


            //initialise le tableau pour le questionnaire grâce au fichier JSON
            using (StreamReader strReader = new StreamReader(path))
            {
                string json = strReader.ReadToEnd();
                lblJason.Text = json;
            }
        }
    }
}
