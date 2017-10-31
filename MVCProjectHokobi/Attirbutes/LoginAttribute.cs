using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProjectHokobi.Attirbutes
{
    public class LoginAttribute: AuthorizeAttribute
    {

        public LoginAttribute(params string[] temp_roller)// kullanıcı, admin  gibi rol tanımlamak için fonksiyon
        {

        }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (httpContext.Session["UserID"] == null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new RedirectResult("/Login/KullaniciGiris");
        }
    }
}