using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace phuongtrinhb1.Controllers
{
    public class phuongtrinhb1Controller : Controller
    {
        // GET: phuongtrinhb1
        public ActionResult phuongtrinhb1()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Timx( string soA , string soB)
        {
            double so1 = Convert.ToDouble(soA);
            double so2 = Convert.ToDouble(soB);
            double GTx = so1 / so2;
            ViewBag.Timgtx=GTx;
            return View();
        }
        
        
    }
}