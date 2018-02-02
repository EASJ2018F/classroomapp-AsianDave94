using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
   public class KlasseRum
    {
        public string KlasseNavn
        {
            get;set;
        }
        List<Studerende> Klasseliste = new List<Studerende>();
        public DateTime SemesterStart
        {
            get;set;
        }
        public KlasseRum()
        {

        }
    }
}
