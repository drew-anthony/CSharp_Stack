using System;
using System.Web;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LostInTheWoods.Factory;
using LostInTheWoods.Models;


namespace LostInTheWoods.Controllers
{
    public class HomeController : Controller
    {
        private readonly TrailsFactory trailsFactory;
        public HomeController(TrailsFactory trail)
        {
            trailsFactory =  trail;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            var AllTrails = trailsFactory.FindAll();
            ViewBag.Trails = AllTrails;
            return View();
        }
        [HttpGet("NewTrail")]
        public IActionResult AddPage()
        {
            
            return View("NewTrail");
        }
        [HttpGet("ShowTrail/{id}")]
        public IActionResult ShowTrail(int? Id)
        {
            
            ViewBag.Trail = trailsFactory.FindByID((int)Id);
            return View();
        }
        [HttpPost("Create")]
        public IActionResult Create(Trail trail)
        {
            if(ModelState.IsValid)
            {

                trailsFactory.Add(trail);
                return RedirectToAction("Index");
                
            }
            else
            {           
                return View("NewTrail",trail);
                
            }            
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}