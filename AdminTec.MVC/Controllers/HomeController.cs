using System.Web.Mvc;

namespace AdminTec.MVC.Controllers
{
    [Authorize()]
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}