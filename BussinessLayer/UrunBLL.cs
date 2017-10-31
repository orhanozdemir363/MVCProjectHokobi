using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer.Repository;
using DataLayer;

namespace BussinessLayer
{
   public class UrunBLL
    {
        Repository<Product> _urunRep;

        public UrunBLL()
        {
            _urunRep = new Repository<Product>();
        }

        public List<Product> Listeleme()
        {
            return _urunRep.Listeleme();
        }

        public Product Detay(string temp_kod)
        {
            return _urunRep.Find(temp_kod);
        }
    }
}
