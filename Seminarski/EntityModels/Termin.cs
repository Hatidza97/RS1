using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seminarski.Models
{
    public class Termin
    {
        public int Id { get; set; }
        public DateTime VrijemeRezervacije { get; set; }
        public Uposlenik Uposlenik { get; set; }
        public int UposlenikId { get; set; }
        public Korisnik Korisnik { get; set; }
        public int KorisnikId { get; set; }
        public Kategorija Kategorija { get; set; }
        public int KategorijaId { get; set; }
        public Usluge Usluge { get; set; }
        public int UslugaId { get; set; }
    }
}
