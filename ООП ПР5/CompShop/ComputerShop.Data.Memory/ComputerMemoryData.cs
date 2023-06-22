using ComputerShop.DI;
using System.Collections.Generic;

namespace ComputerShop.Data.Memory
{
    public class ComputerMemoryData : IData<IComputer>
    {
        private readonly List<IComputer> _computers;

        public ComputerMemoryData()
        {
            _computers = new List<IComputer>();
        }

        public void Add(IComputer item)
        {
            _computers.Add(item);
        }

        public IEnumerable<IComputer> ReadAll()
        {
            return _computers;
        }

        public void Remove(IComputer item)
        {
            _computers.Remove(item);
        }

        public void RemoveAll()
        {

        }
    }


}