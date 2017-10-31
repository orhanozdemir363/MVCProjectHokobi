using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Data.Entity;
using System.Linq.Expressions;

namespace BussinessLayer.Repository
{// Proje bilgi: İnterfaceden türetilmiş class da bulunan fonksiyonlar implement edilerek çalışılır.
    class Repository<T> : IRepository<T> where T : class
    { 
       protected HokobiEntities db;  //Protected ile bir üst türemiş sınıfa ulaşılır
       protected DbSet<T> set;

        public Repository()
        {
            db = new HokobiEntities();
            set = db.Set<T>();
        }

        public bool Add(T item)
        {
            set.Add(item);
            db.SaveChanges();
            return true;
        }

        public bool Delete(T item)
        {
            set.Remove(item);
            db.SaveChanges();
            return true;
        }

        public T Find(params object[] temp_o) // params ;Gönderilecek verinin adedi belli olmadığında kullanılır.
        {
            return set.Find(temp_o);
        }

        public List<T> Listeleme()
        {
            return set.ToList<T>();
        }

        public List<T> Listeleme(Expression<Func<T,bool>> where) // Expression ; sorgu kriteri oluşturur. 
        {
            return set.ToList<T>();
        }

        public bool Update(T item) // item ın durumu kontrol edilerek entity e ekleyen kod satırları
        {
            db.Entry(item).State = EntityState.Modified;
            db.SaveChanges();
            return true;
        }
    }
}
