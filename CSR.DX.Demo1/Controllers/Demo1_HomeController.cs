using System.Web.Mvc;

namespace CSR.DX.Demo1.Controllers
{
    public class Demo1_HomeController : Controller
    {
        // GET: Demo1_Home
        public ActionResult Index()
        {
            return View("~/Plugins/CSR.DX.Demo1/Views/Demo1_Home/Index.cshtml");
        }
    }
}