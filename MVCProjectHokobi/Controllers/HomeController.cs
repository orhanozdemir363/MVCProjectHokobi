using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BussinessLayer;
using DataLayer;
using MVCProjectHokobi.Attirbutes;

namespace MVCProjectHokobi.Controllers
{
    [LoginAttribute]
    public class HomeController : Controller
    {
        // GET: Home
        

        public ActionResult Index()
        {
            Session["KullaniciAdi"] = "b";

            return View();
        }

        public ActionResult Listeleme()
        {

           UrunBLL temp_urunBll = new UrunBLL();
            return View(temp_urunBll.Listeleme());
        }

        public ActionResult Detay(string kod)
        {
            UrunBLL temp_bll = new UrunBLL();

            return View(temp_bll.Detay(kod));
        }
    }
}