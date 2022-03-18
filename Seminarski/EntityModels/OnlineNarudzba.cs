using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seminarski.Models
{
    public class OnlineNarudzba
    {
        public int Id { get; set; }
        public string NazivProizvoda { get; set; }
        public string Ime  { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public float Cijena { get; set; }
        public int Kolicina { get; set; }
        public string Telefon { get; set; }
    }
}
