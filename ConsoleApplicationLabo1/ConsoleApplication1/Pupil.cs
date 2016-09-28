using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Pupil : Person
    {
        private List<Activity> lstActivities;
        private char[] pupilEvaluations;

        public int Grade { get; set; }



        public List<Activity> LstActivities
        {
            get
            {
                return lstActivities;
            }

            set
            {
                lstActivities = value;
            }
        }

        public char[] PupilEvaluations
        {
            get
            {
                return pupilEvaluations;
            }

            set
            {
                pupilEvaluations = value;
            }
        }

        public Pupil(String name, int age, int grade) : base(name, age)
        {
            Grade = grade;
            LstActivities = new List<Activity>();
            pupilEvaluations = new char[Parameter.nbAct];
        }
        public Pupil(String name, int age) : this(name, age, 1) { }
        
        public void AddActivity(Activity act)
        {
            lstActivities.Add(act);
        }
        public override string ToString()
        {

            String chai = Header();
            chai += PrintActivities(chai);
            return chai;
        }

        private string Header()
        {
            string ch = base.ToString();
            int cptActivities = LstActivities.Count();
            if (cptActivities == 0)
            {
                ch += "n'a pas encore choisi d'activité\n";
            }
            else
            {
                ch += "a choisi les activités suivantes :\n";
            }
            return ch;
        }
        private string PrintActivities(String ch)
        {
            foreach (Activity activity in LstActivities)
                ch += " -" + activity.informationMessage() + "\n";
            return ch;
        }

        public void AddEvaluation(String title = null, char evaluation = (char)Parameter.note.Satisfaisant)
        {
            int i;
            for (i = 0; i < Parameter.nbAct && !lstActivities[i].Title.Equals(title); i++) ;
            pupilEvaluations[i] = evaluation;
        }
        public delegate string DelegatePrintActivityCompulsory(Activity activity);
        public string PrintPupilActivityCompulsory(DelegatePrintActivityCompulsory MyPrintActivity)
        {
            int numAct = 0;
            string ch = base.ToString() + " a choisi les activités obligatoires : \n";
            foreach(Activity activity in LstActivities)
            {
                ch += (++numAct) + " " + MyPrintActivity(activity);
            }
            return ch;
        }
    }
}
