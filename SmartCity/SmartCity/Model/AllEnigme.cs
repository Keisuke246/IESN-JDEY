using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCity.Model
{
    public static class AllEnigme
    {
        public static IEnumerable<Enigme> Enigmes { get; set; }

        public static IEnumerable<Enigme> GetAllEnigmes()
        {
            return new List<Enigme>
            {
                new Enigme("Question1","Solution1"),
                new Enigme("Question2", "Solution2"),
                new Enigme("Question3", "Solution3")
            };
        }
    }
}
