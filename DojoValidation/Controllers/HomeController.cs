using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoValidation.Models;

namespace DojoValidation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create(Ninja ninja)
        {
            if(ModelState.IsValid)
            {
               return RedirectToAction("Result", ninja);
            }
            else
            {           
                return View("Index",ninja);
            }
        }
        public IActionResult Result(Ninja ninja)
        {
            return View("Result", ninja);
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
