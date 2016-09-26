using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2
{
    class PrivateContact : Person
    {
        private int phoneNumber;
        private String mailAdress;
        private DateTime birthDate;

        public int PhoneNumber
        {
            get
            {
                return phoneNumber;
            }

            set
            {
                phoneNumber = value;
            }
        }

        public string MailAdress
        {
            get
            {
                return mailAdress;
            }

            set
            {
                mailAdress = value;
            }
        }

        public DateTime BirthDate
        {
            get
            {
                return birthDate;
            }

            set
            {
                birthDate = value;
            }
        }

        public PrivateContact(String name, String lastName, int phone, String mail, DateTime birthDate) :this(name,lastName,phone,mail)
        {
            BirthDate = birthDate;
        }
        public PrivateContact(String name, String lastName, int phone, String mail) : base(name, lastName)
        {
            PhoneNumber = phone;
            MailAdress = mail;
        }

        public override bool HasHisBirthday()
        {
            return (DateTime.Today.Month == BirthDate.Month && DateTime.Today.Day == BirthDate.Day);
        }
        public String ToString()
        {
            return base.ToString() + " (" + PhoneNumber + ")";
        }
    }
}
