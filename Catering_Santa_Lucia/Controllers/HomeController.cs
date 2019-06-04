using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Catering_Santa_Lucia.Models;
//using Catering_Santa_Lucia.Data;

namespace Catering_Santa_Lucia.Controllers
{
    public class HomeController : Controller
    {
        //UsuarioContext db = new UsuarioContext();
        public IActionResult Index()
        {
            //var data = db.Usuario;
            return View();
        }

        public IActionResult IndexGeneral()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult PrivacyGeneral()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
