using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSL
{
    public class Questionnaire
    {
        public int questNumber { get; set; }
        public string question { get; set; }
        public string[] answers { get; set; }
        public int correct_answer { get; set; }

        public class Rootobject
        {
            public QuestionQ[] questions { get; set; }
        }

        public class QuestionQ
        {
            public int questNumber { get; set; }
            public string question { get; set; }
            public string[] answers { get; set; }
            public int correct_answer { get; set; }
        }
        //https://docs.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-how-to?pivots=dotnet-5-0
        //https://www.softwaretestinghelp.com/create-json-objects-using-c/
        //https://coderwall.com/p/vxspdq/simple-json-array-methods-in-c

        //https://www.newtonsoft.com/json/help/html/DeserializeDataSet.htm
    }
}
