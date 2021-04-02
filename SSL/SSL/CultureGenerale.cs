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
        public string path = "..\\..\\Resources\\data.json";
        //Créer une liste de question qui stockera toutes les questions du fichier JSON
        public List<Question> QuestionsAll;
        //string retourner par JsonConverter depuis fichier JSON
        public string jsonData = "";
        public int questionActuelle = 0;
        public Question q;
        public bool labelClicked;

        public int nbJoueurMax;
        public int numJoueurActuel;

        //référence pour revenir au menu précédent (Jouer)
        private Jouer RefToJouer;
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

        private void picBoxRight_Click(object sender, EventArgs e)
        {
            NextQuestion();
        }

        private void NextQuestion()
        {
            //Affiche la prochaine question
            questionActuelle++;
            //s'il n'y a plus d'autre question enlève la flèche suivante et affiche un message box
            if (questionActuelle >= QuestionsAll.Count)
            {
                picBoxRight.Visible = false;
                MessageBox.Show("Il n'y a n'y a plus d'autre questions, vous allez être redirigez vers le tableau des scores");
                //Show tableau des scores 
                RefToJouer.Show();
                this.Close();
            }
            else
            {
                //permet de cliquer à nouveau sur les réponses
                labelClicked = false;

                lblQuestion.Text = QuestionsAll[questionActuelle].question;
                GenerationReponse();
                //affiche le joueur suivant et reset le compteur s'il n'y a plus de nouveaux joueur
                if (numJoueurActuel < nbJoueurMax-1)
                {
                    numJoueurActuel++;
                    lblJoueur.Text = Player.listPlayer[numJoueurActuel].Nom;
                }
                else
                {
                    numJoueurActuel = 0;
                    lblJoueur.Text = Player.listPlayer[numJoueurActuel].Nom;
                }
            }
        }


        private void btnRepCarre_Click(object sender, EventArgs e)
        {
            panelChoixReponse.Visible = false;
            tableCarre.Visible = true;
            GenerationReponse();
        }


        private void CultureGenerale_Load(object sender, EventArgs e)
        {
            //initialise le tableau pour le questionnaire grâce au fichier JSON
            //using (StreamReader sr = new StreamReader(path, Encoding.Latin1))
            using (StreamReader sr = new StreamReader(path))
            {
                jsonData = sr.ReadToEnd();
            }
            QuestionsAll = JsonConvert.DeserializeObject<List<Question>>(jsonData);

            //load la première question
            lblQuestion.Text = QuestionsAll[questionActuelle].question;
            //compte le nombre total de joueur
            nbJoueurMax = Player.listPlayer.Count;
            numJoueurActuel = 0;
            //affiche le premier joueur
            lblJoueur.Text = Player.listPlayer[numJoueurActuel].Nom;
        }

        private void btnRepCash_Click(object sender, EventArgs e)
        {

        }

        private void GenerationReponse()
        {
            //génère un tableau des 4 contrôles pour afficher les réponses
            TableLayoutControlCollection controls = tableCarre.Controls;

            //permet de cliquer à nouveau sur les label pour contrôler les réponse
            //labelClicked = false;

            //Créer un objet de type question en fonction du numéro de questionActuelle depuis liste QuestionsAll
            q = QuestionsAll[questionActuelle];

            //pour chaque contrôle affiche la réponse associée
            int i = 0;//permet d'itérer dans le tableau answers[] associé à la question pour afficher chaque réponse
            foreach (Control item in controls)
            {
                item.Text = q.answers[i];
                item.ForeColor = Color.Black;
                i++;
            }
        }

        private void lblRep1_Click(object sender, EventArgs e)
        {
            while (!labelClicked)
            {
                //récupère le texte du label qui a été cliqué et envoie le string pour contrôle de la réponse
                if (CheckReponse((sender as Label).Text))
                {
                    BonneReponse(sender);
                }
                else
                {
                    MauvaiseReponse(sender);
                }
                //empêche de clicker à nouveau sur d'autre réponse.
                labelClicked = true;
            }            
        }

        private bool CheckReponse(string text)
        {
            bool estJuste;
            //retourne la bonne réponse 
            string correctAnswer = q.answers[q.correct_answer - 1];

            //compare le label cliqué et la bonne réponse
            if (text == correctAnswer)
            {
                estJuste = true;
            }
            else
            {
                estJuste = false;
            }
            return estJuste;
        }

        private void BonneReponse(object sender)
        {
            (sender as Label).ForeColor = Color.FromArgb(0, 192, 0);
            //point du joueur ++;
            Player.listPlayer[numJoueurActuel].Score++;
        }

        private void MauvaiseReponse(object sender)
        {
            (sender as Label).ForeColor = Color.FromArgb(192, 0, 0);
        }
    }
}
