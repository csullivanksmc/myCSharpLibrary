using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace guessing.Controllers
{
    public class gameController : Controller
    {
        // GET: game
        public ActionResult Index()
        {
            return View();
        }
    }
}