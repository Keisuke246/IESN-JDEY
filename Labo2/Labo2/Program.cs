using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrivateContact contact1 = new PrivateContact("Yassin", "Lazrak", 0472847232, "yassin.lazrak@gmail.com");
            PrivateContact contact2 = new PrivateContact("Jérôme", "Dey", 0477857941, "deyjerome@gmail.com", DateTime.Today);
            if (contact2.HasHisBirthday())
                System.Console.Write("Bon anniversaire !");
            else
                System.Console.Write("Pas son annif hein");

            ProfessionalContact consultant1 = new ProfessionalContact("Antoine", "Durieux", "Consultant", 0481267834, "antoine.durieux@burco.be");
            ProfessionalContact consultant2 = new ProfessionalContact("Jean", "Dubuisson", "Consultant", 0485843791, "j.dubuisson@burco.be");
            ProfessionalContact independant = new ProfessionalContact("Philippe", "Malur", "Indépendant", 0483479412, "philippe.malur@gmail.com");

            Enterprise company1 = new Enterprise("Jerome & co", "rue des noisettes 5060 Sambreville");
            Enterprise company2 = new Enterprise("Chalal soccer", "rue des souliers 1000 Bruxelle");
            consultant1.AddCompany(company1);
            consultant1.AddCompany(company2);
            consultant2.AddCompany(company2);

            List<ProfessionalContact> pros = new List<ProfessionalContact>()
            {
                consultant1,
                consultant2,
                independant
            };
            var independents = from pro in pros
                               where pro.Job.Equals("Indépendant")
                               select pro;
            var consultants = pros.Where(f => f.Job.Equals("Consultant") && f.Companies.Any(e => e.Equals(company2)));
            //System.Console.Write(independents.Count());
            Car car1 = new Car("1-JKF-772");
            ContactCar contactCar = new ContactCar(contact1, car1);
            contactCar.DynamicPrint(contact1);

            Car car2 = new Car("1-FDJ-874");
            ContactCar contactCar2 = new ContactCar(independant, car2);
            contactCar2.DynamicPrint(independant);
            System.Console.Read();

        }
    }
}
