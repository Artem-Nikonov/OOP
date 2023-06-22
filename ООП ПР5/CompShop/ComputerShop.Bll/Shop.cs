using ComputerShop.DI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.Bll
{
    public class Shop : IShop
    {
        private readonly IData<IComputer> _compData;
        private readonly IData<ICheck> _checkData;

        public string Name { get; set; }
        public string Address { get; set; }

        public Shop(IData<IComputer> compData, IData<ICheck> checkData)
        {
            _compData = compData ?? throw new ArgumentNullException(nameof(compData));
            _checkData = checkData ?? throw new ArgumentNullException(nameof(checkData));
        }

        public void Add(IComputer computer)
        {
            _compData.Add(computer);
        }

        public IEnumerable<IComputer> GetAllComputers()
        {
            return _compData.ReadAll();
        }

        public IEnumerable<ICheck> GetAllChecks() 
        { 
            return _checkData.ReadAll(); 
        }

        public ICheck Sell(IComputer computer)
        {
            _compData.Remove(computer);
            var check = new Check()
            {
                Computer = computer,
                Shop = this,
                DateTime = DateTime.Now
            };

            _checkData.Add(check);
            return check;
        }

        public void ResetAll()
        {
            _compData.RemoveAll();
            _checkData.RemoveAll();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
