using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Utbildningstillfalle
    {
        string Namn;
        string Akronym;
        int Startår;
        string Kursansvarig;
        

        public Utbildningstillfalle(string namn, string akronym, int startår, string kursansvarig)
        {
            Namn = namn;
            Akronym = akronym;
            Startår = startår;
            Kursansvarig = kursansvarig;
         }
    }
}
