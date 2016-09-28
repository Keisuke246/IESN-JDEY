using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2
{
    class Enterprise
    {
        private String name;
        private String headQuartersLocation;

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

        public string HeadQuartersLocation
        {
            get
            {
                return headQuartersLocation;
            }

            set
            {
                headQuartersLocation = value;
            }
        }

        public Enterprise(String name,String headQuartersLocation)
        {
            Name = name;
            HeadQuartersLocation = headQuartersLocation;
        }
        public String ToString()
        {
            return Name + " located at " + HeadQuartersLocation;
        }
    }
}

