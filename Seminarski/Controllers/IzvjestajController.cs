using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Seminarski.ViewModels;
using Seminarski.EF;
using Rotativa.AspNetCore;

namespace Seminarski.Controllers
{
    public class IzvjestajController : Controller
    {
        MojDBContext _db = new MojDBContext();
        public IActionResult IzvjestajPDF()
        {
            IzvjestajVM PDF = new IzvjestajVM
            {
                rows = _db.CjenovnikUsluga.Include(i => i.Usluge)
                .Where(i => i.Cijena > 0.00)
                .Select(
                    i => new IzvjestajVM.Rows
                    {
                        UslugaId = i.UslugeId,
                        NazivUsluge = i.Usluge.Naziv,
                        Opis = i.Usluge.Opis,
                        Cijena = i.Cijena,
                        Trajanje = i.VrijemeTrajanja
                    }).ToList()
            };
            return new ViewAsPdf("IzvjestajPDF", PDF);
        }
    }
}
