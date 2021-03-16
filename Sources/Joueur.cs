using System;
using System.Collections.Generic;
using System.Text;

namespace SSL
{
    class Joueur
    {      
        // Variables internes
        private string _nom;
        private int _score;
        private string _team;
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

        public string Equipe
        {
            get { return _team;}
            set { _team = value; }
        }
        // Constructeur

        // par default
        public Joueur( string nom): this(nom,0,"")
        { }

        //désigné
        public Joueur(string nom, int score ,string equipe)
        {
            _nom = nom;
            _score = score;
            _team = equipe;

        }
    }
}
