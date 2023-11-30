using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Schemarad
    {
        public DateOnly Datum { get; set; }
        public TimeOnly Starttid { get; set; }
        public TimeOnly Sluttid { get; set; }
        public string Moment { get; set; }
        public string Hjalpmedel { get; set; }

        public List<Larare> larare { get; set; }
        public List<Sal> sal { get; set; }

        public Schemarad(DateOnly datum, TimeOnly starttid, TimeOnly sluttid, string moment, string hjalpmedel)
        {
            Datum = datum;
            Starttid = starttid;
            Sluttid = sluttid;
            Moment = moment;
            Hjalpmedel = hjalpmedel;
        }
    }
}
