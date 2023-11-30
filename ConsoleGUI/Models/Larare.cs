using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Larare
    {

        public string Fornamn { get; }
        public string Efternamn { get; }
        public string Signatur { get; }

        public Larare(string fornamn, string efternamn, string signatur)
        {
            Fornamn = fornamn;
            Efternamn = efternamn;
            Signatur = signatur;

        }

    }
}
