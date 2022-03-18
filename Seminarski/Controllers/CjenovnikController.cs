using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Seminarski.EF;
using Seminarski.Models;
using Seminarski.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PagedList;
using PagedList.Mvc;
namespace Seminarski.Controllers
{
    public class CjenovnikController:Controller
    {
     public IActionResult Index()
        {
            MojDBContext _db = new MojDBContext();
            var model = new CjenovnikIndexVM
            {
                rows = (List<CjenovnikIndexVM.Rows>)_db.CjenovnikUsluga
                .Select(
                    i => new CjenovnikIndexVM.Rows
                    {
                        Id=i.Id,
                        Cijena = i.Cijena,
                        Trajanje = i.VrijemeTrajanja.ToString(),
                        Opis = i.Opis,
                        Usluga = i.Usluge.Naziv
                    }).ToList()
            };
            return View(model);
        }  
        public IActionResult Uredi(int id)
        {
            MojDBContext _db = new MojDBContext();
            var usluge = _db.CjenovnikUsluga
                .Include(i => i.Usluge)
                .Where(i => i.Id == id)
                .SingleOrDefault();
            var model = new CjenovnikUrediVM
            {
                Id = id,
                NazivUsluge = usluge.Usluge.Naziv,
                Cijena = usluge.Cijena,
                Opis = usluge.Opis,
                Trajanje = usluge.VrijemeTrajanja
            };
            return View(model);
        }
        public IActionResult Dodaj ()
        {
            MojDBContext _db = new MojDBContext();
            return View();
        }
        public IActionResult SnimiNovo(CjenovnikDodajVM vm)
        {
            MojDBContext _db = new MojDBContext();
            var usluga = new Usluge
            {
                Naziv = vm.NazivUsluge,
                Opis = vm.Opis
            };
            _db.Add(usluga);
            _db.SaveChanges();
            var novaUsluga = new CjenovnikUsluga
            {
                Cijena = vm.Cijena,
                VrijemeTrajanja = vm.Trajanje,
                UslugeId = usluga.Id,
                Opis = vm.Opis
            };
            _db.CjenovnikUsluga.Add(novaUsluga);
            _db.SaveChanges();
            return Redirect("/Cjenovnik/Index");
        }
        public IActionResult Snimi(CjenovnikUrediVM vm)
        {
            MojDBContext _db = new MojDBContext();
            var usluga = _db.CjenovnikUsluga.
                Include(i => i.Usluge)
                .Where(i => i.Id == vm.Id)
                .SingleOrDefault();

            usluga.Cijena = vm.Cijena;
            usluga.VrijemeTrajanja = vm.Trajanje;
            usluga.Opis = vm.Opis;
            _db.SaveChanges();
            return Redirect("/Cjenovnik/Index");
        }
    }
}
