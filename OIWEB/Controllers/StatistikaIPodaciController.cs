using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OIWEB.Controllers
{
    public class StatistikaIPodaciController : Controller
    {
        ObrazovniInformatorDataContext oi = new ObrazovniInformatorDataContext();
        // GET: StatistikaIPodaci
        public ActionResult Index()
        {
            var statistika = from s in oi.StatistickiPodacis
                             select s;
            return View(statistika.ToList());
        }
    }
}