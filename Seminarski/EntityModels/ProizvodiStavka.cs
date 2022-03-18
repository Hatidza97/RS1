using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seminarski.Models
{
    public class ProizvodiStavka
    {
        public int Id { get; set; }
        public int Kolicina { get; set; }
        public Proizvodi Proizvodi { get; set; }
        public int ProizvodId { get; set; }
        public Skladište Skladište { get; set; }
    }
}
