using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Seminarski.EF;
using Seminarski.EntityModels;
using Seminarski.Helpers;
using Seminarski.ViewModels;

namespace Seminarski.Controllers
{
    public class AutentifikacijaController : Controller
    {

        //private readonly MojDBContext _db;
        //public AutentifikacijaController(MojDBContext db)
        //{
        //    _db = db;
        //}
        MojDBContext _db = new MojDBContext();
        public IActionResult Index()
        {
            return View(new LoginVM()
            {
                ZapamtiPassword = true
            }); ;
        }
        public IActionResult Login(LoginVM vm)
        {
            KorisnickiNalog korisnik = _db.KorisnickiNalog
                .SingleOrDefault(x => x.Username == vm.Username && x.Password == vm.Password);
            if (korisnik == null)
            {
                TempData["error_poruka"] = "Pogrešan username ili password";
                return View("Index",vm);
            }
            HttpContext.SetLogiraniKorisnik(korisnik);
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Logout()
        {
            return RedirectToAction("Index");
        }
    }
}
