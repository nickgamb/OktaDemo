using System.Web;
using System.Web.Mvc;

namespace OktaDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [Authorize]
        public ActionResult Profile()
        {
            return View();
        }
    }
}