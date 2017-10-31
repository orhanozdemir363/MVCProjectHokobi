using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Repository
{
   public interface IRepository<T> where T:class
    {
        bool Add(T item);
        bool Update(T item);
        bool Delete(T item);
        List<T> Listeleme();
        T Find(params object[] temp_o);
    }
}
