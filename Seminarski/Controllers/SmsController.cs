using Nexmo.Api;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Seminarski.ViewModels;
using Seminarski.EF;
using Seminarski.Models;

namespace Seminarski.Controllers
{
    public class SmsController : Controller
    {
         // GET: SMSMessage  
            public IActionResult Index()
            {
                return View();
            }

            [HttpGet]
            public IActionResult SendMessage()
            {
                return View();
            }

            [HttpPost]
            public IActionResult SendMessage(Message message)
            {
            MojDBContext _db = new MojDBContext();
                var results = SMS.Send(new SMS.SMSRequest
                {
                    from =Configuration.Instance.Settings["appsettings:NEXMO_FROM_NUMBER"],
                    to = "+38762769446",
                    text = message.SadrzajPoruke
                });
                
                return View();
            }
        
    }
}
