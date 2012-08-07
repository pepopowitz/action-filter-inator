using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ActionFilterInator.ActionFilters;

namespace ActionFilterInator.Controllers
{
    //[QsToggle] pgpgpg - i could apply this here if I wanted more granular control than global....
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        //[QsToggle] pgpgpg -  i can apply this here if i want really granular control...
        public ActionResult Index()
        {
            return View();
        }

    }
}
