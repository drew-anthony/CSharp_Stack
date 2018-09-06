    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    namespace YourNamespace.Controllers     //be sure to use your own project's namespace!
    {
        public class HelloController : Controller   //remember inheritance??
        {
            //for each route this controller is to handle:
            [HttpGet]       //type of request
            [Route("")]     //associated route string (exclude the leading /)
            public IActionResult Index()
            {
                return View();
            }
            [HttpGet]       //type of request
            [Route("projects")]     //associated route string (exclude the leading /)
            public IActionResult Projects()
            {
                return View("projects");
            }
            [HttpGet]       //type of request
            [Route("contact")]     //associated route string (exclude the leading /)
            public IActionResult Contact()
            {
                return View("contact");
            }
        }
    }