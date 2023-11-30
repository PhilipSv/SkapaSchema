using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Sal
    {

        public string Nummer { get; }
        public int AntalPlatser { get; }

        public Sal(string nummer, int antalPlatser)
        {
            Nummer = nummer;
            AntalPlatser = antalPlatser;
        }
    }
}
