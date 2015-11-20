using System.Web.Mvc;

namespace AlisonVogel.Web.Controllers
{
    public class AboutController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "About";
            return View();
        }

	}
}