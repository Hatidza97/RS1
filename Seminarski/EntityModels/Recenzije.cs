using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seminarski.Models
{
    public class Recenzije
    {
        public int Id { get; set; }
        public string Opis { get; set; }
        public Usluge Usluge { get; set; }
        public int UslugaId { get; set; }
        public Korisnik Korisnik { get; set; }
        public int KorisnikId { get; set; }
    }
}
