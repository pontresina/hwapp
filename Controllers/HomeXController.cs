// http://holdirbootstrap.de/los-gehts/
// http://labs.thecssninja.com/bootleg/index.html#
// http://code.makery.ch/library/html-css/de/part7/
// return redirect("/")
// Form, Query String and HttpContext in ASP.NET Core 1.0
// http://www.binaryintellect.net/articles/03953fd4-ec09-4a69-bcde-78dcc0b8d68e.aspx

using Microsoft.AspNetCore.Mvc;

namespace ConsoleApplication.Controllers
{
    public class HomeXController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public IActionResult GetForm()
        {
        string firstName = HttpContext.Request.Form["firstname"];
        string lastName = HttpContext.Request.Form["lastname"];
        ViewBag.Message = $"Welcome {firstName} {lastName}!";
        return View("Index");
        }

        public IActionResult ProcessForm()
        {
            HttpContext.Items["firstname"] = HttpContext.Request.Form["firstname"];
            HttpContext.Items["lastname"] = HttpContext.Request.Form["lastname"];
            string firstName = HttpContext.Request.Form["firstname"];
            string lastName = HttpContext.Request.Form["lastname"];
            //ViewBag.Message = helper.DoWork();
            ViewBag.Message = $"Welcome {firstName} {lastName}!";
            ViewBag.firstName = firstName;
            try
            {
            } 
            catch(System.Exception e)
            {
            }

            return View("Index");
        }

        public ActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Error()
        {
            return View();
        }
    }
}