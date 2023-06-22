using ComputerShop.DI;

namespace ComputerShop.Data.Sql
{
    public class ComputerEntity:IComputer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Firm { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }


        public ComputerEntity() { }

        public ComputerEntity(IComputer item)
        {
            Id = 0;
            Name = item.Name;
            Firm = item.Firm;
            Price = item.Price;
            Quantity = item.Quantity;
        }

        public override string ToString() => $"{Firm}\t{Name}\t{Price}$\tx{Quantity}";

    }
}