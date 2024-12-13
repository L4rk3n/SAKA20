using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAKA20_DB2.Entities
{
    public class Vin
    {
        public int Idvin { get; set; }
        public string Nom { get; set; }
        public int Cuvee { get; set; }
        public string Type { get; set; }
        public string Format { get; set; }
        public string Fournisseur { get; set; }
        public bool Disponible { get; set; }
        public int Stock { get; set; }
        public string Empalpha { get; set; }
        public int Empnum { get; set; }
        public int Prix { get; set; }
        public int Prixtva { get; set; }
    }
}
