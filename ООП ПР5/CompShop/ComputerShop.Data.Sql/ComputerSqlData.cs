using ComputerShop.DI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.Data.Sql
{
    public class ComputerSqlData : IData<IComputer>
    {
        public void Add(IComputer item)
        {
            using (var db = new ComputerShopContext())
            {
                var computer = new ComputerEntity(item);
                var ComputerInShop = db.Computers.SingleOrDefault(b => b.Firm.Equals(computer.Firm) &&
                   b.Name.Equals(computer.Name) &&
                   b.Price.Equals(computer.Price));

                if(ComputerInShop!= null )
                {
                    ComputerInShop.Quantity += computer.Quantity;
                }
                else
                {
                    db.Computers.Add(computer);
                }
                db.SaveChanges();
            }
        }

        public IEnumerable<IComputer> ReadAll()
        {
            using (var db = new ComputerShopContext())
            {
                return db.Computers.ToList();
            }
        }

        public void Remove(IComputer item)
        {
            using (var db = new ComputerShopContext())
            {
                var computer = db.Computers.SingleOrDefault(b => b.Firm.Equals(item.Firm) &&
                    b.Name.Equals(item.Name) &&
                    b.Price.Equals(item.Price));
                if (computer.Quantity > 1)
                {
                    computer.Quantity -= 1;
                }
                else
                {
                    db.Computers.Remove(computer);
                }
    
                db.SaveChanges();
            }
        }


        public void RemoveAll()
        {
            using (var db = new ComputerShopContext())
            {
                foreach(var comp in db.Computers)
                {
                    db.Computers.Remove(comp);
                }
                db.SaveChanges();
            }
        }

    }
}
