using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Seminarski.ViewModels
{
    public class LoginVM
    {
        [StringLength(100,ErrorMessage="Korisnicko ime mora sadrzavati minimalno 3 karaktera.", MinimumLength = 3)]
        public string Username { get; set; }
        [StringLength(100, ErrorMessage = "Password mora sadrzavati minimalno 4 karaktera.", MinimumLength = 4)]
        public string Password { get; set; }
        public bool ZapamtiPassword { get; set; }
    }
}
