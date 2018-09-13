using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RESTauranter.Models;
using Microsoft.EntityFrameworkCore;

namespace RESTauranter.Controllers
{
    public class HomeController : Controller
    {
        private RestContext _context;
        public HomeController(RestContext context)
        {
            _context = context;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            
            return View();
        }
        [HttpGet("Reviews")]
        public IActionResult Reviews()
        {
            List<REST> Allreviews = _context.reviews.ToList();
            var ordered = from review in Allreviews
            orderby review.Visit descending 
            select review;
            ViewBag.Reviews = ordered;
            return View();
        }
        [HttpPost("Create")]
        public IActionResult Create(REST rest)
        {
            // REST NewRest = new REST
            // {
            //     Name = rest.Name,
            //     Restaurant = rest.Restaurant,
            //     Review = rest.Review,
            //     Rate = rest.Rate,
            //     Visit = rest.Visit
            // };
            if(ModelState.IsValid)
            {
                _context.Add(rest);
                _context.SaveChanges();
                return RedirectToAction("Reviews");
            }
                
                      
                return RedirectToAction("Index", rest);          
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
