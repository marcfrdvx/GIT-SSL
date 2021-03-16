using System;
using System.Collections.Generic;
using System.Text;

namespace SSL
{
    class Equipe
    {
        // Variables internes
        private string _nom;
        private int _score;
        private string _joueur;
        // Proprietes

        public string Nom
        {
            get { return _nom; }
        }

        public int Score
        {
            get { return _score; }
            set { _score = value; }
        }

        public string Joueur
        {
            get { return _joueur; }
            set { _joueur = value; }
        }
        // Constructeur

        // par default
        public Equipe(string nom) : this(nom, 0, "")
        { }

        //désigné
        public Equipe(string nom, int score, string joueur)
        {
            _nom = nom;
            _score = score;
            _joueur = joueur;

        }

        //Methodes
        
        private void addPlayer(string addPlayer)
        {
            List<string> players = new List<string>();
        }
    }
}
