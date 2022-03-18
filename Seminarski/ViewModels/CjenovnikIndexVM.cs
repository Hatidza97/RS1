using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PagedList;
using PagedList.Mvc;
namespace Seminarski.ViewModels
{
    public class CjenovnikIndexVM
    {
        public List<Rows> rows { get; set; }
        public class Rows
        {
            public int Id { get; set; }
            public float Cijena { get; set; }
            public string Usluga { get; set; }
            public string Trajanje { get; set; }
            public string Opis { get; set; }
        }
    }
}
