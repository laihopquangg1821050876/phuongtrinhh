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
        public ActionResult PTB1()
        {
            return View();
        
        }
        [HttpPost]
        public ActionResult PTB1(string soX, string soY)
        public ActionResult PTB1(string soA, string soB)
        {
            double soa = Convert.ToDouble(soX);
            double sob = Convert.ToDouble(soY);
            double ketqua = sob / soa;
            double so1 = Convert.ToDouble(soA);
            double so2 = Convert.ToDouble(soB);
            double ketqua = so2 / so1;
            ViewBag.Giaipt = ketqua;
            return View();


        }
}