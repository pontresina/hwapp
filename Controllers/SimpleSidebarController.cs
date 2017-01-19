using Microsoft.AspNetCore.Mvc;

namespace ConsoleApplication.Controllers
{
    public class SimpleSidebarController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
       
    }
}