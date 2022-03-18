using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Seminarski.EF;
using Seminarski.ViewModels;
using Seminarski.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Web;
using Microsoft.Extensions.Hosting.Internal;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using X.PagedList;
using System.Web.Http.Cors;


namespace Seminarski.Controllers
{
   
    public class ProizvodController : Controller
    {
        private IHostingEnvironment Environment;
        private readonly IHostingEnvironment hosting;
        public ProizvodController(IHostingEnvironment _environment)
        {
            Environment = _environment;
        }
        //public MojDBContext _db;
        //public ProizvodController(MojDBContext context)
        //{
        //    _db = context;
        //}
        public IActionResult Index1(int? page)
        {
            MojDBContext _db = new MojDBContext();


            var model = new ProizvodiVM
            {
                rows = _db.Proizvodi.OrderBy(i => i.Naziv)
                .Select(
                    i => new ProizvodiVM.Rows
                    {
                        ProizvodId = i.Id,
                        Cijena = i.Cijena,
                        Kategorija = i.Kategorija.NazivKategorije,
                        Kolicina = i.Kolicina,
                        Proizvod = i.Naziv,
                        Opis = i.Opis,
                        StanjeNaSkladistu = i.StanjeNaSkladistu,
                        Slika = Path.GetFileName(i.ImageUrl)

                    }).ToList()
            };
            return View(model.rows.ToPagedList(page ?? 1,3));
        }
        public async Task<IActionResult> IndexAngular()
        {
            MojDBContext _db = new MojDBContext();
            //var proizvodi = _db.Proizvodi;
            //return Ok(Json(await proizvodi.ToListAsync()));
            var model = new ProizvodiVM
            {
                rows = _db.Proizvodi.OrderBy(i => i.Naziv)
                .Select(
                    i => new ProizvodiVM.Rows
                    {
                        ProizvodId = i.Id,
                        Cijena = i.Cijena,
                        Kategorija = i.Kategorija.NazivKategorije,
                        Kolicina = i.Kolicina,
                        Proizvod = i.Naziv,
                        Opis = i.Opis,
                        StanjeNaSkladistu = i.StanjeNaSkladistu,
                        Slika = Path.GetFileName(i.ImageUrl)

                    }).ToList()
            };
            return Ok(Json((model.rows)));
        }
        //[HttpPost]
        //public IActionResult IndexSlika(List<IFormFile> postedFiles)
        //{
        //    string wwwPath = this.Environment.WebRootPath;
        //    string contentPath = this.Environment.ContentRootPath;

        //    string path = Path.Combine(this.Environment.WebRootPath, "images");
        //    if (!Directory.Exists(path))
        //    {
        //        Directory.CreateDirectory(path);
        //    }

        //    List<string> uploadedFiles = new List<string>();
        //    foreach (IFormFile postedFile in postedFiles)
        //    {
        //        string fileName = Path.GetFileName(postedFile.FileName);
        //        using (FileStream stream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
        //        {
        //            postedFile.CopyTo(stream);
        //            uploadedFiles.Add(fileName);
        //            ViewBag.Message += string.Format("<b>{0}</b> uploaded.<br />", fileName);
        //        }
        //    }

        //    return Redirect("/Proizvod/Snimi/");
        //}
        public IActionResult Dodaj()
        {
            MojDBContext _db = new MojDBContext();
            
            var model = new ProizvodiDodajVM
            {
                Kategorije = _db.Kategorija
                .Select(
                    i => new SelectListItem
                    {
                        Value = i.Id.ToString(),
                        Text = i.NazivKategorije
                    }).ToList()
            };
            return View(model);
        }
        private string SaveFile(IFormFile file)
        {
            string uploadFileName = null;
            string filePath = null;
            if (file != null)
            {
                string uploadFoloder = Path.Combine(hosting.WebRootPath, "images");
                uploadFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                filePath = Path.Combine(uploadFoloder, uploadFileName);
                file.CopyTo(new FileStream(filePath, FileMode.Create));
                return "~/images/" + uploadFileName;
            }
            return null;
        }
 
        public IActionResult Snimi(ProizvodiDodajVM vm)
        {
            string uniquefileName = null;
            if (vm.SlikaUrl != null)
            {
                //string uploadsFolder = Path.Combine(hosting.WebRootPath, "images");
                //string uploadsFolder = ("C:/Users/Hatidza/Desktop/Seminarski/Seminarski/wwwroot/images");
                string uploadsFolder = Environment.WebRootPath + "/images";
                uniquefileName = Guid.NewGuid().ToString() + "_" + vm.SlikaUrl.FileName;
                string path = Path.Combine(uploadsFolder, uniquefileName);
                //vm.SlikaUrl.CopyTo(new FileStream(Path.Combine(path, uniquefileName), FileMode.Create));
                vm.SlikaUrl.CopyTo(new FileStream(path, FileMode.Create));
            }
            MojDBContext _db = new MojDBContext();
            var kategorija = _db.Kategorija.Find(vm.KategorijaID);
            var noviProizvod = new Proizvodi
            {
                NazivKategorijeID =kategorija.Id,
                StanjeNaSkladistu = (int)vm.StanjeNaSkladistu,
                Cijena = vm.Cijena,
                Kolicina = (int)vm.Kolicina,
                Naziv = vm.Proizvod,
                Opis = vm.Opis,
                Kategorija=kategorija,
                ImageUrl=uniquefileName
            };
            _db.Add(noviProizvod);
            _db.SaveChanges();
            return Redirect("/Proizvod/Index1");
        }
        public IActionResult Uredi(int id)
        {
            MojDBContext _db = new MojDBContext();
            var proizvod = _db.Proizvodi
                .Include(i => i.Kategorija)
                .Where(i => i.Id == id)
                .SingleOrDefault();
            var model = new ProizvodUrediVM
            {
                ProizvodID = id,
                NazivProizvoda = proizvod.Naziv,
                Cijena = proizvod.Cijena,
                Kategorija = proizvod.Kategorija.NazivKategorije,
                KategorijaID = proizvod.Kategorija.Id,
                Kolicina = proizvod.Kolicina,
                Opis=proizvod.Opis,
                SlikaUrl=proizvod.ImageUrl
            };
            return View(model);
        }
        public IActionResult SnimiUredjeno(ProizvodUrediVM vm)
        {
            MojDBContext _db = new MojDBContext();
            var proizvod = _db.Proizvodi
                .Include(i => i.Kategorija)
                .Where(i => i.Id == vm.ProizvodID)
                .SingleOrDefault();
                
            proizvod.Cijena = vm.Cijena;
            proizvod.Kolicina = vm.Kolicina;
            proizvod.Opis = vm.Opis;
            _db.SaveChanges();
            return Redirect("/Proizvod/Index1");
        }
        public IActionResult Obrisi(int id)
        {
            MojDBContext _db = new MojDBContext();
            var proizvod = _db.Proizvodi
                .Include(i => i.Kategorija)
                .Where(i => i.Id == id)
                .SingleOrDefault();
            _db.Remove(proizvod);
            _db.SaveChanges();
            return Redirect("/Proizvod/Index1");
        }
       
    }
}
