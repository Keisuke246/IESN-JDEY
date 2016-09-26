using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2
{
    class ProfessionalContact : Person
    {
        private String job;
        private int privatePhoneNumber;
        private String proMail;
        private List<Enterprise> companies;
        public ProfessionalContact(String name, String lastName, String job,int privatePhoneNumber, String proMail) : base(name, lastName)
        {
            Job = job;
            PrivatePhoneNumber = privatePhoneNumber;
            ProMail = proMail;
            Companies = new List<Enterprise>();
        }

        public string Job
        {
            get
            {
                return job;
            }

            set
            {
                job = value;
            }
        }

        public int PrivatePhoneNumber
        {
            get
            {
                return privatePhoneNumber;
            }

            set
            {
                privatePhoneNumber = value;
            }
        }

        public string ProMail
        {
            get
            {
                return proMail;
            }

            set
            {
                proMail = value;
            }
        }

        public List<Enterprise> Companies
        {
            get
            {
                return companies;
            }

            set
            {
                companies = value;
            }
        }

        public String ToString()
        {
            return base.ToString() + " (" + PrivatePhoneNumber + ")\n" +
                   Job + "\n" +
                   ProMail + "\n";
        }
        public override bool HasHisBirthday()
        {
            return false;
        }
        public void AddCompany(Enterprise company)
        {
            companies.Add(company);
        }
        public String Print()
        {
            return base.ToString() + " est un contact professionel";
        }
    }
}
