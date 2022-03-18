using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seminarski.ViewModels
{
    public class CjenovnikUrediVM
    {
        public int Id { get; set; }
        public string NazivUsluge { get; set; }
        public float Cijena { get; set; }
        public string Trajanje { get; set; }
        public string Opis { get; set; }
    }

}
