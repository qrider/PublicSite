using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using quentinrider.ViewModels;

namespace quentinrider.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewData.Model = new HomeIndexModel();
            return View();
        }

    }
}
