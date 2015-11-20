using System.Web.Mvc;

namespace AlisonVogel.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home";
            return View();
        }

    }
}