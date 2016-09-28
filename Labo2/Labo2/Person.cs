using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2
{
    public abstract class Person
    {
        private String name;
        private String lastName;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }
        public Person(String name, String lastName)
        {
            Name = name;
            LastName = lastName;
        }
        public String ToString()
        {
            return Name + " " + LastName;
        }
        public abstract bool HasHisBirthday();
    }
}
