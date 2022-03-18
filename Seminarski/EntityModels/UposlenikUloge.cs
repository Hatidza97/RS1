using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seminarski.Models
{
    public class UposlenikUloge
    {
        public int Id { get; set; }
        public string Uloga { get; set; }
        public Uposlenik Uposlenik { get; set; }
        public int UposlenikId { get; set; }
    }
}
