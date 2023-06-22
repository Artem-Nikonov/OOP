using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.DI
{
    public interface IShop
    {
        string Name { get; set; }
        string Address { get; set; }

        void Add(IComputer computer);
        IEnumerable<IComputer> GetAllComputers();
        IEnumerable<ICheck> GetAllChecks();
        ICheck Sell(IComputer computer);
        void ResetAll();
    }


    public interface IComputer
    {
        string Name { get; set; }
        string Firm { get; set; }
        int Price { get; set; }
        int Quantity { get; set; }
    }



    public interface ICheck
    {
        IShop Shop { get; set; }
        IComputer Computer { get; set; }
        DateTime DateTime { get; set; }
    }



    public interface IData<T>
    {
        IEnumerable<T> ReadAll();
        void Add(T item);
        void Remove(T item);
        void RemoveAll();
    }

  

}
