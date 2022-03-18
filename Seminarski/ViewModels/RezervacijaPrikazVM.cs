using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seminarski.ViewModels
{
    public class RezervacijaPrikazVM
    {
        public int TerminId { get; set; }
        public int Id { get; set; }
        public string Usluge { get; set; }
        public DateTime Datum { get; set; }
        public int UposlenikId { get; set; }
        public string Uposlenici { get; set; }
        public string Titula { get; set; }
        public int KategorijaId { get; set; }
        public string Kategorija { get; set; }
    }
}
