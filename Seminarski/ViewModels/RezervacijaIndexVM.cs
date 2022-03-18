using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seminarski.ViewModels
{
    public class RezervacijaIndexVM
    {
            public int TerminId { get; set; }
            public int Id { get; set; }
            public List<SelectListItem> Usluge { get; set; }
            public DateTime Datum { get; set; }
            public int UposlenikId { get; set; }
            public List<SelectListItem> Uposlenici { get; set; }
            public string Titula { get; set; }
            public int KategorijaId { get; set; }
            public List<SelectListItem> Kategorija { get; set; }
    }
}
