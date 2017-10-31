using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BussinessLayer;
using DataLayer;

namespace MVCProjectHokobi.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            
                return View();
            
        }

        [HttpPost]
        public ActionResult KullaniciGiris(FormCollection temp_c)
        {
            BussinessLayer.LoginBLL temp_loginBLL = new BussinessLayer.LoginBLL();

            if (temp_loginBLL.KullaniciGiris(temp_c[0], temp_c[1]))
            {
                Session["KullaniciAdi"] = temp_c[0];
                return RedirectToAction("Listeleme", "Home");
            }
            else
            {
                ViewBag.Mesaj = "Giriş Bilgileri Hatalı";
                return View();
            }
        }
    }
    
}