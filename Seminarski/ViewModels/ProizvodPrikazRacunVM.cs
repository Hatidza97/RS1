using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seminarski.ViewModels
{
    public class ProizvodPrikazRacunVM
    {
        public List<Rows> rows { get; set; }
        public class Rows
        {
            public int ProizvodId { get; set; }
            public string Naziv { get; set; }
            public string Opis { get; set; }
            public float Cijena { get; set; }
            public float Popust { get; set; }
            public int Kolicina { get; set; }

        }
    }
}
