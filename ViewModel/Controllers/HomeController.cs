using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModel.Models;

namespace ViewModel.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            string Messages;
            Messages = "asdfafasdfkladfjkahjdsfklhadfjkhasjkdflhaskldfhakjsdfhajksdfhajkldfhaksdlfhaskljfhakdlfhasdlkfjh";
            return View("index", Messages);
        }
        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            int[] Numbers = new int[]
            {
                1,2,3,10,43,5
            };
            return View("numbers", Numbers);
        }
        [HttpGet("users")]
        public IActionResult Users()
        {
            Users user1 =  new Users("Drew", "Anthony");
            Users user2 = new Users("Barry", "Bonds");
            Users user3 = new Users("Mike", "Trout");
            Users[] users = {user1, user2, user3};
            return View("users", users);
        }
        [HttpGet("user")]
        public IActionResult User1()
        {
            Users user = new Users("Drew", "Anthony");
            return View("user", user);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
