using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seminarski.Models
{
    public class Notifikacije
    {
        public int Id { get; set; }
        public string Poruka { get; set; }
        public Korisnik Korisnik { get; set; }
        public int KorisnikId { get; set; }
    }
}
