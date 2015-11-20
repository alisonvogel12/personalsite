using System.Web.Mvc;

namespace AlisonVogel.Web.Controllers
{
    public class ResumeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public FileResult ViewResume()
        {
            return File("~/Files/AlisonVogelResume.PDF", "application/pdf");
        }
	}
}