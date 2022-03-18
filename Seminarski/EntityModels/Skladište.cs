using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seminarski.Models
{
    public class Skladište
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public float Cijena { get; set; }
        public int Kolicina { get; set; }
        public string ImeDobavljaca { get; set; }
        public DateTime DatumPrijema { get; set; }
        public Uposlenik Uposlenik { get; set; }
        public int UposlennikId { get; set; }
    }
}
