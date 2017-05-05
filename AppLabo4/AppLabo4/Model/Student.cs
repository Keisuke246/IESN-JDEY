using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLabo4.Model
{
    public class Student
    {
        public String Name { get; set; }

        public Student(String name, int age)
        {
            Name = name;
        }
    }
}
