using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PagedList;
using PagedList.Mvc;
namespace Seminarski.ViewModels
{
    public class ProizvodiVM
    {
        public int Id { get; set; }
        public List<Rows> rows { get; set; }
        public class Rows
        {
            public int ProizvodId { get; set; }
            public string Kategorija { get; set; }
            public string Proizvod { get; set; }
            public float Cijena { get; set; }
            public float Kolicina { get; set; }
            public float StanjeNaSkladistu { get; set; }
            public string Opis { get; set; }
            public string Slika { get; set; }
            public byte[] SlikaByte { get; set; }
        }
    }
}
