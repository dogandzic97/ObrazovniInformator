using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OIWEB.Controllers
{
    public class SpecificnostiBudzetskihKorisnikaController : Controller
    {
        ObrazovniInformatorDataContext oi = new ObrazovniInformatorDataContext();
        // GET: SpecificnostiBudzetskihKorisnika
        public ActionResult Index()
        {
            //STRANICA DRZAVNA UPRAVA, ima ID 1
            var clanci = from c in oi.Clancis
                         where c.IDSBK==1
                         select c;

            List<ClanciTxt> text = (from t in oi.ClanciTxts
                                    select t).ToList();
            ViewBag.Tekstovi = text;
            return View(clanci.ToList());
        }

        public ActionResult LokalnaSamouprava()
        {
            //STRANICA LOKALNA SAMOUPRAVA, ima ID 2
            var clanci = from c in oi.Clancis
                         where c.IDSBK == 2
                         select c;

            List<ClanciTxt> text = (from t in oi.ClanciTxts
                                    select t).ToList();
            ViewBag.Tekstovi = text;
            return View(clanci.ToList());
        }

        public ActionResult Zdravstvo()
        {
            //STRANICA ZDRAVSTVO, ima ID 3
            var clanci = from c in oi.Clancis
                         where c.IDSBK == 3
                         select c;

            List<ClanciTxt> text = (from t in oi.ClanciTxts
                                    select t).ToList();
            ViewBag.Tekstovi = text;
            return View(clanci.ToList());
        }

        public ActionResult Prosveta()
        {
            //STRANICA PROSVETA, ima ID 4
            var clanci = from c in oi.Clancis
                         where c.IDSBK == 4
                         select c;

            List<ClanciTxt> text = (from t in oi.ClanciTxts
                                    select t).ToList();
            ViewBag.Tekstovi = text;
            return View(clanci.ToList());
        }

        public ActionResult SocijalnaZastita()
        {
            //STRANICA SOCIJALNA ZASTITA, ima ID 5
            var clanci = from c in oi.Clancis
                         where c.IDSBK == 5
                         select c;

            List<ClanciTxt> text = (from t in oi.ClanciTxts
                                    select t).ToList();
            ViewBag.Tekstovi = text;
            return View(clanci.ToList());
        }
        public ActionResult Kultura()
        {
            //STRANICA KULTURA, ima ID 6
            var clanci = from c in oi.Clancis
                         where c.IDSBK == 6
                         select c;

            List<ClanciTxt> text = (from t in oi.ClanciTxts
                                    select t).ToList();
            ViewBag.Tekstovi = text;
            return View(clanci.ToList());
        }

        public ActionResult Nauka()
        {
            //STRANICA NAUKA, ima ID 7
            var clanci = from c in oi.Clancis
                         where c.IDSBK == 7
                         select c;

            List<ClanciTxt> text = (from t in oi.ClanciTxts
                                    select t).ToList();
            ViewBag.Tekstovi = text;
            return View(clanci.ToList());
        }
        public ActionResult Pravosudje()
        {
            //STRANICA PRAVOSUDJE, ima ID 8
            var clanci = from c in oi.Clancis
                         where c.IDSBK == 8
                         select c;

            List<ClanciTxt> text = (from t in oi.ClanciTxts
                                    select t).ToList();
            ViewBag.Tekstovi = text;
            return View(clanci.ToList());
        }

        public ActionResult OmladinaISport()
        {
            //STRANICA OMLADINA I SPORT, ima ID 9
            var clanci = from c in oi.Clancis
                         where c.IDSBK == 9
                         select c;

            List<ClanciTxt> text = (from t in oi.ClanciTxts
                                    select t).ToList();
            ViewBag.Tekstovi = text;
            return View(clanci.ToList());
        }

        public ActionResult JavnaPreduzeca()
        {
            //STRANICA JAVNA PREDUZECA, ima ID 10
            var clanci = from c in oi.Clancis
                         where c.IDSBK == 10
                         select c;

            List<ClanciTxt> text = (from t in oi.ClanciTxts
                                    select t).ToList();
            ViewBag.Tekstovi = text;
            return View(clanci.ToList());
        }
    }
}