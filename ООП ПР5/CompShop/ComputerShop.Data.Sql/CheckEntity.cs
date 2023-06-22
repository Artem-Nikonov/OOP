using ComputerShop.DI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.Data.Sql
{
    public class CheckEntity : ICheck
    {
        public int Id { get; set; }
        public string ShopName { get; set; }
        public string ComputerName { get; set; }
        public IShop Shop { get; set; }
        public IComputer Computer { get; set; }
        public DateTime DateTime { get; set; }

        public CheckEntity() { }

        public CheckEntity(ICheck item)
        {
            Id = 0;
            Shop = item.Shop;
            ShopName = item.Shop.Name;
            Computer = item.Computer;
            ComputerName = item.Computer.Name;
            DateTime = item.DateTime;
        }

        public override string ToString()
        {
            return $"{DateTime}\t{ShopName}\t{ComputerName}";
        }
    }
}
