using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CSR.DX.Library;

namespace CSR.DX.UI.Controllers
{
    public class StartupController : Controller
    {
        // GET: Startup
        public ActionResult Index()
        {
            return Content("Total " + PluginManager.PluginTypes.Count.ToString() + " Plugins"  );
        }
    }
}