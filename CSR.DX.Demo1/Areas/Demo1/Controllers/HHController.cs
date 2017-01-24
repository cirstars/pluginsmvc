using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSR.DX.Demo1.Areas.Demo1.Controllers
{
    public class HHController : Controller
    {
        // GET: Demo1/HH
        public ActionResult Index()
        {
            return View("~/Plugins/CSR.DX.Demo1/Areas/Demo1/Views/HH/Index.cshtml");
        }
    }
}