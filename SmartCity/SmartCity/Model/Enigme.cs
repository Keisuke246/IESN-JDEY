using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCity.Model
{
    public class Enigme
    {
        public int Id { get; set; }
        public String Question { get; set; }
        public String Solution { get; set; }
        public Enigme(String question, String solution)
        {
            Question = question;
            Solution = solution;
        }
    }
}
