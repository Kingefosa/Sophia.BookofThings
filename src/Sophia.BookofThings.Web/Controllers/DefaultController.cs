using System.Web.Mvc;

namespace Sophia.BookofThings.Web.Controllers
{
    public class DefaultController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}