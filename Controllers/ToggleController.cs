using Microsoft.AspNetCore.Mvc;

namespace ConsoleApplication.Controllers
{
    public class ToggleController : Controller
    {
        public ActionResult Index()
        {

/*            var result = await context.
        .Include(ctx=> ctx.Artist)
        .Include(ctx=> ctx.Tracks)
        .OrderBy(alb=> alb.Title)
        .ToListAsync();*/

            return View();
        }
       
    }
}