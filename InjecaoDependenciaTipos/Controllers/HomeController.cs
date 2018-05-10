using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InjecaoDependenciaTipos.Models;

namespace InjecaoDependenciaTipos.Controllers
{
    public class HomeController : Controller
    {
        private readonly IScoped scoped;
        private readonly ITransient transient;
        private readonly ISingleton singleton;

        public HomeController(IScoped scoped, ITransient transient, ISingleton singleton)
        {
            this.scoped = scoped;
            this.transient = transient;
            this.singleton = singleton;
        }
      
        public IActionResult Index()
        {
            ViewBag.Scoped = this.scoped;
            ViewBag.Transient = this.transient;
            ViewBag.Singleton = this.singleton;

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

