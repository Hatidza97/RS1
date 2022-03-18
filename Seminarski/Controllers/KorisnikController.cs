using Microsoft.AspNetCore.Mvc;
using Seminarski.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Seminarski.Models;
using Seminarski.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Seminarski.Controllers
{
    public class KorisnikController: Controller
    {
        //private readonly MojDBContext _db;

        //public KorisnikController(MojDBContext db)
        //{
        //    _db = db;
        //}

        public IActionResult Prikaz()
        {
            MojDBContext db = new MojDBContext();
            List<Korisnik> podaci = db.Korisnici.ToList();
            ViewData["nekiKey"] = podaci;

            return View();
        }
        public IActionResult InsertKorisnik(KorisnikInsert k)
        {
            MojDBContext _db = new MojDBContext();
            { return View(); }
           
        }
        public IActionResult Insert(KorisnikInsert data)
        {
            MojDBContext _db = new MojDBContext();
            Korisnik userForInput = new Korisnik
            {
                Ime = data.Ime,
                Prezime = data.Prezime,
                Username = data.Username,
                Telefon = data.Telefon,
                Mail = data.Mail,
                Lozinka = data.Lozinka
            };

            _db.Korisnici.Add(userForInput);
            _db.SaveChanges();
            return Redirect("Prikaz");
        }
        //public IActionResult UrediView(int id)
        //{
        //    MojDBContext _db = new MojDBContext();
        //    var korisnik = _db.Korisnici.Find(id);
        //    return View(korisnik);

        //}
        public IActionResult Uredi(int id)
        {
            MojDBContext _db = new MojDBContext();
            var korisnik = _db.Korisnici.Where(i => i.Id == id).SingleOrDefault();
            var model = new KorisnikUrediVM
            {
                Id=id,
                Ime = korisnik.Ime,
                Prezime = korisnik.Prezime,
                BrojTel = korisnik.Telefon,
                Email = korisnik.Mail,
                Username = korisnik.Username,
                Sifra = korisnik.Lozinka
            };
            return View(model);
        }
        public IActionResult SnimiUredjeno(KorisnikUrediVM vm)
        {
            MojDBContext _db = new MojDBContext();
            var korisnik = _db.Korisnici.Find(vm.Id);
            korisnik.Ime = vm.Ime;
            korisnik.Prezime = vm.Prezime;
            korisnik.Mail = vm.Email;
            korisnik.Username = vm.Username;
            korisnik.Lozinka = vm.Sifra;
            korisnik.Telefon = vm.BrojTel;
            _db.SaveChanges();
            return Redirect("/Korisnik/Prikaz");

                
        }
        public IActionResult Obrisi(int id)
        {
            MojDBContext _db = new MojDBContext();
            var korisnik = _db.Korisnici.Find(id);
            if (korisnik != null)
            {
                _db.Korisnici.Remove(korisnik);
                _db.SaveChanges();
            }
            return Redirect("/Korisnik/Prikaz");

        }
    }
}
