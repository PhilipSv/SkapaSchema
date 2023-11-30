using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Schema
    {
        public string Namn { get; set; }
        public Utbildningstillfalle utbildningstillfalle { get; }

        public List<Schemarad> schemarader = new List<Schemarad>();

        public Schema(string namn)
        {
            Namn = namn;
        }
    }

}
