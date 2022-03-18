using Microsoft.EntityFrameworkCore;
using Seminarski.EntityModels;
using Seminarski.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seminarski.EF
{
    public class MojDBContext:DbContext
    {
        public DbSet<Korisnik> Korisnici { get; set; }
        public DbSet<Uposlenik> Uposlenici { get; set; }
        public DbSet<CjenovnikUsluga> CjenovnikUsluga { get; set; }
        public DbSet<Kategorija> Kategorija { get; set; }
        public DbSet<NarudzbaStavka> NarudzbaStavka { get; set; }
        public DbSet<OnlineNarudzba> OnlineNarudzba { get; set; }
        public DbSet<Notifikacije> Notifikacije { get; set; }
        public DbSet<Proizvodi> Proizvodi { get; set; }
        public DbSet<ProizvodiStavka> ProizvodiStavka { get; set; }
        public DbSet<Recenzije> Recenzije { get; set; }
        public DbSet<Salon> Salon { get; set; }
        public DbSet<Skladište> Skladište { get; set; }
        public DbSet<StanjeSkladista> StanjeSkladista { get; set; }
        public DbSet<Termin> Termin { get; set; }
        public DbSet<UposlenikUloge> UposlenikUloge { get; set; }
        public DbSet<Usluge> Usluge { get; set; }
        public DbSet<KorisnickiNalog> KorisnickiNalog { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {

            optionsBuilder.UseSqlServer(@" Server=.;

                                            Database=IB160182;

                                            Trusted_Connection=true;

                                            MultipleActiveResultSets=true;");

        }

    }
}
