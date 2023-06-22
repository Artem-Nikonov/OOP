using ComputerShop.DI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.Data.Sql
{
    public class CheckSqlData : IData<ICheck>
    {
        public void Add(ICheck item)
        {
            using (var db = new ComputerShopContext())
            {
                var check = new CheckEntity(item);
                db.Checks.Add(check);
                db.SaveChanges();
            }
        }

        public IEnumerable<ICheck> ReadAll()
        {
            using (var db = new ComputerShopContext())
            {
                return db.Checks.ToList();
            }
        }

        public void Remove(ICheck item)
        {
            using (var db = new ComputerShopContext())
            {
                var check = new CheckEntity(item);
                db.Checks.Remove(check);
                db.SaveChanges();
            }
        }

        public void RemoveAll()
        {
            using (var db = new ComputerShopContext())
            {
                foreach (var check in db.Checks)
                {
                    db.Checks.Remove(check);
                }
                db.SaveChanges();
            }
        }

    }
}
