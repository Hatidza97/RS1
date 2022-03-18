using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seminarski.ViewModels
{
    public class NotifikacijePosaljiVM
    {
        public int UserID { get; set; }
        public string Useri { get; set; }
       // public int NotifikacijaID { get; set; }
        public string Poruka { get; set; }
    }
}
