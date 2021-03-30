using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSL
{
    public class Player
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
            get { return _team; }
            set { _team = value; }
        }

        //ID joueur
        // Constructeur

        // par default
        public Player(string nom) : this(nom, 0, "")
        { }

        //désigné
        public Player(string nom, int score, string equipe)
        {
            _nom = nom;
            _score = score;
            _team = equipe;
        }

        public override string ToString()
        {
            string joueur = "";
            joueur = this._nom + " , score : " + this._score;
            return joueur;
        }
    }
}
