using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class PersonComparer : IEqualityComparer<Person>
    {
        public bool Equals(Person x, Person y)
        {
            if ((x.Equals(y) || x.Age == y.Age || x.Name.Equals(y.Name)))
            {
                return true;
            }
            return false;
        }

        public int GetHashCode(Person obj)
        {
            return obj.Name.GetHashCode()+obj.Age.GetHashCode();
        }
    }
}
