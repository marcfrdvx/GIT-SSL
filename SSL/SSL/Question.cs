using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSL
{
    public class Question
    {

        //public Question[] QuestionsArray { get; set; }

        public int number { get; set; }
        public string question { get; set; }
        public List<string> answers { get; set; }
        public int correct_answer { get; set; }

        public override string ToString()
        {
            string s = "";
            string answers = "";
            for (int i = 0; i < 4; i++)
            {
                answers += this.answers[i] + "\n";
            }
            s = String.Format("Numéro : {0}\nQuestion : {1}\nRéponses : {2}\nCorrect : {3}", this.number, this.question, answers, this.correct_answer);
            return s;
        }

        public class Root
        {
            public List<Question> questions { get; set; }
        }
    }
}
