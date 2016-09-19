using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil etu1 = new Pupil("Lucas", 8);
            Pupil etu2 = new Pupil("Antoine", 5, 3);
            Pupil etu3 = new Pupil("Marie", 7, 2);
            Pupil etu4 = new Pupil("Léo", 8, 1);
            Activity act1 = new Activity("Natation", true);
            Activity act2 = new Activity("Physique", false);
            Activity act3 = new Activity("Gymnastique", true);

            etu1.AddActivity(act1);
            etu1.AddActivity(act2);
            etu1.AddActivity(act3);

            System.Console.Write(etu1.ToString());

            Activity act4 = new Activity("Coloriage", true);
            etu1.AddActivity(act4);
            etu1.AddEvaluation("Coloriage", 'R');
            etu1.AddEvaluation(evaluation: 'T', title: "Natation");

            List<Pupil> lstPupil = new List<Pupil>();
            lstPupil.Add(etu2);
            lstPupil.Add(etu3);
            lstPupil.Add(etu4);

            var pupilGrade1Plus6 = from pupil in lstPupil
                                   where pupil.Age > 6 && pupil.Grade == 1
                                   select pupil;
            if(pupilGrade1Plus6 != null)
            {
                foreach(var pupils in pupilGrade1Plus6)
                {
                    System.Console.Write(pupils.ToString());
                }
            }
            System.Console.Read();
        }
    }
}
