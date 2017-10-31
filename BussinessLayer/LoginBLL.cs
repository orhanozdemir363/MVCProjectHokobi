using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer.Repository;
using DataLayer;

namespace BussinessLayer
{
    

 public class LoginBLL
    {
        Repository.Repository<User> _kullaniciRep;

        public LoginBLL()
        {
            _kullaniciRep = new Repository<User>();
        }

        public bool KullaniciGiris(string temp_kullaniciAdi, string temp_sifre)
        {
            List<User> temp_k = _kullaniciRep.Listeleme(k => k.UserName == temp_kullaniciAdi && k.PasswordSalt == temp_sifre);

            if (temp_k.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
