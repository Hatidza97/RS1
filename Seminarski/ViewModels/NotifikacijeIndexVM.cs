using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Seminarski.ViewModels
{
    public class NotifikacijeIndexVM
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string Poruka { get; set; }

    }
}
