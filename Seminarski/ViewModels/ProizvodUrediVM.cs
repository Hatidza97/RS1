using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seminarski.ViewModels
{
    public class ProizvodUrediVM
    {
        public int ProizvodID { get; set; }
        public string NazivProizvoda { get; set; }
        public int KategorijaID { get; set; }
        public string Kategorija { get; set; }
        public float Cijena { get; set; }
        public int Kolicina { get; set; }
        public string Opis { get; set; }
        public string SlikaUrl { get; set; }
    }
}
