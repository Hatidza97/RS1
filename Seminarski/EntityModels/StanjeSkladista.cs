using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seminarski.Models
{
    public class StanjeSkladista
    {
        public int Id { get; set; }
        public Proizvodi Proizvodi { get; set; }
        public int ProizvodId { get; set; }
        public int Kolicina { get; set; }

    }
}
