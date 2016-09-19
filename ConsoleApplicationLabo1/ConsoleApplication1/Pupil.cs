using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Pupil : Person
    {
        private List<Activity> lstActivities;
        private char[] tabEval;

        public int Grade { get; set; }

        public char[] TabEval
        {
            get
            {
                return tabEval;
            }

            set
            {
                tabEval = value;
            }
        }

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
        public Pupil(String name, int age, int grade) : base(name, age)
        {
            Grade = grade;
            LstActivities = new List<Activity>();
            TabEval = new char[10];
        }
        public Pupil(String name, int age) : this(name, age, 1) { }
        
        public void AddActivity(Activity act)
        {
            lstActivities.Add(act);
        }
        public override string ToString()
        {
            string ch = base.ToString();
            int cptActivities = LstActivities.Count();
            if(cptActivities == 0)
            {
                ch += "n'a pas encore choisi d'activité\n";
            }
            else
            {
                ch += "a choisi les activités suivantes :\n";
                foreach (Activity activity in LstActivities)
                    ch += activity.informationMessage() + "\n";
            }
            return ch;
        }
        public void AddEvaluation(String title = null, char evaluation = 'S')
        {
            int i = 0;
            while(!lstActivities[i].Title.Equals(title))
            {
                i++;
            }
            tabEval[i] = evaluation;
        }
    }
}
