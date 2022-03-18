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
    public class NotifikacijeController : Controller
    {
        public IActionResult Index(int id)
        {

            MojDBContext _db = new MojDBContext();
            var model = new NotifikacijeIndexVM
            {
                Id = id,
                User = _db.Korisnici.Where(i => i.Id == id).Select(i => i.Ime + " " + i.Prezime).SingleOrDefault()
            };
            //if (model.Poruka != null)
            //    return RedirectToAction("Posalji", model) ;
            //else
            return View(model);
        }
        public IActionResult Posalji(NotifikacijeIndexVM vm)
        {
            MojDBContext _db = new MojDBContext();
            // NotifikacijeIndexVM param = vm;
            var korisnik = _db.Korisnici.Find(vm.Id);
            var model = new NotifikacijePosaljiVM
            {
                UserID = vm.Id,
                Poruka = vm.Poruka,
                Useri = vm.User
            };
            var notifikacija = new Notifikacije
            {
                KorisnikId = vm.Id,
                Korisnik = korisnik,
                Poruka = vm.Poruka
            };
            _db.Add(notifikacija);
            _db.SaveChanges();

            return View(model);

        }
        public IActionResult Prikaz()
        {
            MojDBContext _db = new MojDBContext();
            var list = _db.Notifikacije.ToList();
            List<NotifikacijaPrikazVM> model = new List<NotifikacijaPrikazVM>();
            foreach (var x in list)
            {
                var korisnikID = x.KorisnikId;
                var korisnikImePrezime = _db.Korisnici.Where(x => x.Id == korisnikID).Select(i => i.Ime + " " + i.Prezime).FirstOrDefault();
                var poruka = x.Poruka;
                var element = new NotifikacijaPrikazVM
                {

                    ImePrezime = korisnikImePrezime,
                    Poruka = poruka

                };
                model.Add(element);
            }
            return View(model);
        }
    }
}
