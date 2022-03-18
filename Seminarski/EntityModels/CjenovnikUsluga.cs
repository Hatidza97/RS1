using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seminarski.Models
{
    public class CjenovnikUsluga
    {
        public int Id { get; set; }
        public float Cijena { get; set; }
        public Usluge Usluge { get; set; }
        public int UslugeId { get; set; }
        public string VrijemeTrajanja { get; set; }
        public string Opis { get; set; }
    }
}
