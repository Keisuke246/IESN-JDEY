using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Activity
    {
        private String title;
        private Boolean compulsory;

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public bool Compulsory
        {
            get
            {
                return compulsory;
            }

            set
            {
                compulsory = value;
            }
        }

        public Activity(String title, Boolean compulsory)
        {
            Title = title;
            Compulsory = compulsory;
        }
        public String informationMessage()
        {
            return title + " " +(compulsory ? "(obligatoire)" : "");
        }
    }
}
