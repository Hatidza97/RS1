using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Seminarski.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seminarski.ViewModels
{
    public class ProizvodiDodajVM
    {
        public int ProizvodId { get; set; }
        public int KategorijaID { get; set; }
        public List<SelectListItem> Kategorije{ get; set; }
        public string Proizvod { get; set; }
        public float Cijena { get; set; }
        public float Kolicina { get; set; }
        public float StanjeNaSkladistu { get; set; }
        public string Opis { get; set; }
        public IFormFile SlikaUrl { get; set; }
    }
}
