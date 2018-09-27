using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WeddingPlanner.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace WeddingPlanner.Controllers
{
    public class HomeController : Controller
    {
        private LoginContext _context;
        public HomeController(LoginContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("login/user")]
        public IActionResult LoginUser()
        {
            return View("Login");
        }

        [HttpPost("register")]
        public IActionResult Register(User userReg)
        {
            if (ModelState.IsValid){
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                userReg.Password = Hasher.HashPassword(userReg, userReg.Password);
                _context.Add(userReg);
                _context.SaveChanges();
                return RedirectToAction("Success");
            }
            else {
                return View("Index", userReg);
            }
            
        }

        [HttpPost("login")]
        public IActionResult Login(User userLog)
        {
            var user = _context.Users.SingleOrDefault(u => u.Email == userLog.Email);
            if(user != null && userLog.Password != null)
            {
                var Hasher = new PasswordHasher<User>();
                if(0 != Hasher.VerifyHashedPassword(user, user.Password, userLog.Password))
                {
                    return RedirectToAction("LoginSuccess");
                }
            }
            return View("Login", userLog);
        }

        [HttpGet("success")]
        public IActionResult Success()
        {
            return View();
        }

        [HttpGet("login/success")]
        public IActionResult LoginSuccess() 
        {
            return View();
        }
    }
}