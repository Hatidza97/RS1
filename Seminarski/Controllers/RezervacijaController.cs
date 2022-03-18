using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Seminarski.EF;
using Seminarski.Models;
using Seminarski.ViewModels;

namespace Seminarski.Controllers
{
    public class RezervacijaController : Controller
    {
        MojDBContext _db = new MojDBContext();
        public IActionResult Index()
        {
            MojDBContext _db = new MojDBContext();
            var Model = new RezervacijaIndexVM
            {
                Usluge = _db.Usluge
                .Select(i => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem
                {
                    Value = i.Id.ToString(),
                    Text = i.Naziv
                }).ToList(),
                Uposlenici = _db.Uposlenici.Select
                (i => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem
                {
                    Value = i.Id.ToString(),
                    Text = i.Ime + " " + i.Prezime
                }).ToList(),
                Kategorija = _db.Kategorija
                .Select
                (i => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem
                {
                    Value = i.Id.ToString(),
                    Text = i.NazivKategorije
                }).ToList()
            };
            return View(Model);
        }
        public IActionResult Rezervisi(RezervacijaIndexVM vm)
        {
            var uposlenik = _db.Uposlenici.Find(vm.UposlenikId);
            var usluga = _db.Usluge.Find(vm.Id);
            var kategorija = _db.Kategorija.Find(vm.KategorijaId);
            // var d1 = vm.Datum.TimeOfDay;
            var d2 = _db.Termin.Where(i => i.VrijemeRezervacije.Day == vm.Datum.Day).Select(i => i.VrijemeRezervacije.TimeOfDay).FirstOrDefault();
            //if (d1 < d2.SingleOrDefault())
            //{

            //}
            //string relationship;

            //  var date = vm.Datum.CompareTo(_db.Termin.Select(i => i.VrijemeRezervacije));
            var noviTermin = new Termin
            {
                VrijemeRezervacije = vm.Datum,
                UslugaId = usluga.Id,
                UposlenikId = uposlenik.Id,
                KategorijaId = kategorija.Id,
                KorisnikId = 1
            };
            if (noviTermin.VrijemeRezervacije.TimeOfDay > d2 ||
                noviTermin.VrijemeRezervacije.TimeOfDay < d2)
                _db.Termin.Add(noviTermin);
            _db.SaveChanges();
            return Redirect("/Rezervacija/Prikaz/");
        }
        public IActionResult Prikaz(RezervacijaPrikazVM vm)
        {
            //    var kategorija = _db.Kategorija.Find(vm.KategorijaId);
            //    var uposlenik = _db.Uposlenici.Find(vm.UposlenikId);
            //    var usluga = _db.Usluge.Find(vm.Id);
            //    var vam = new RezervacijaPrikazVM
            //    {
            //        Datum = vm.Datum,
            //       KategorijaId = vm.KategorijaId,
            //        Kategorija=kategorija.NazivKategorije,
            //        UposlenikId = uposlenik.Id,
            //        Uposlenici=uposlenik.Ime+" "+uposlenik.Prezime,
            //        Id = usluga.Id,
            //        Usluge=usluga.Naziv,
            //        Titula=uposlenik.Titula
            //    };
            //    return View(vam);
           // var termin = _db.Termin.Find(terminid);
            var model = new RezervacijaPrikazVM
            {
                Datum = _db.Termin.Select(s=>s.VrijemeRezervacije).FirstOrDefault(),
                Kategorija=_db.Termin.Select(i=>i.Kategorija.NazivKategorije).FirstOrDefault(),
                Uposlenici=_db.Termin.Select(j=>j.Uposlenik.Ime+" "+j.Uposlenik.Prezime).FirstOrDefault(),
                Usluge=_db.Usluge.Select(t=>t.Naziv+" : "+t.Opis).FirstOrDefault()
            };
            return View(model);
        }
        public IActionResult Nazad()
        {
            return Redirect("/Home/Index/");
        }

    } 
}
