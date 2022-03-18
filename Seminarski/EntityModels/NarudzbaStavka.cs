using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seminarski.Models
{
    public class NarudzbaStavka
    {
        public int Id { get; set; }
        public int Kolicina { get; set; }
        public OnlineNarudzba OnlineNarudzba { get; set; }
        public int OnlineNarudzbaId { get; set; }
        public Proizvodi Proizvodi { get; set; }
        public int ProizvodID { get; set; }
        public Kategorija Kategorija { get; set; }
        public int KategorijaID { get; set; }

    }
}
