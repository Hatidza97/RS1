using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seminarski.Models
{
    public class Proizvodi
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public float Cijena { get; set; }
        public int StanjeNaSkladistu { get; set; }
        public int Kolicina { get; set; }
        public string Opis { get; set; }
        public virtual Kategorija Kategorija { get; set; }
        public int NazivKategorijeID { get; set; }
        public string ImageUrl { get; set; }
    }
}
