// https://startbootstrap.com/template-overviews/sb-admin/
// Toggled
// https://blackrockdigital.github.io/startbootstrap-simple-sidebar/
/*
        [Route("")]
        [Route("SBAdmin")]
        [Route("SBAdmin/Index")]

        [HttpPost]
        
*/
using Microsoft.AspNetCore.Mvc;

namespace ConsoleApplication.Controllers
{
    public class SBAdminController : Controller
    {
        public ActionResult Index()
        {
            // public ViewResult Index()

            // Generates /Products/Buy/17?color=red
            //var url = Url.Action("Home", "Index", new { id = 17, color = "red" });
            //return Content(url);
            return View();
        }

        public ActionResult Tables()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public ActionResult Error()
        {
            return View();
        }
        
    }
}