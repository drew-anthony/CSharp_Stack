    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    namespace DojoSurvey.Controllers     //be sure to use your own project's namespace!
    {
        public class UserController : Controller   //remember inheritance??
        {
            //for each route this controller is to handle:
            [HttpGet]       //type of request
            [Route("")]     //associated route string (exclude the leading /)
            public IActionResult Index()
            {
                return View();
            }
            [HttpPost]       //type of request
            [Route("result")]     //associated route string (exclude the leading /)
            public IActionResult Result(string name, string location, string language, string comment)
            {
                ViewBag.Name = name;
                ViewBag.Location = location;
                ViewBag.Language = language;
                ViewBag.Comment = comment;
                return View("result");
            }
        }
    }