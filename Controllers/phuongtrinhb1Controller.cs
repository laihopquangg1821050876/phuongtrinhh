using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace phuongtrinhb1.Controllers
{
    public class phuongtrinhb1Controller 
    {
        // GET: phuongtrinhb1
        public ActionResult phuongtrinhb1()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Timx(string soA, string soB)
        {
            double so1 = Convert.ToDouble;
            double so2 = Convert.ToDouble;
            double gtx = so2 / so1;
            ViewBag.timgtx = gtx;
            double so1 = Convert.ToDouble(soA);
            double so2 = Convert.ToDouble(soB);
            double gt_x = -so2 / so1;
            ViewBag.timgtx = gt_x;
            return View();
        }
    }
}