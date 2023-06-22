using ComputerShop.DI;
namespace ComputerShop.Bll
{
    public class Computer : IComputer
    {
        public string Name { get; set; }
        public string Firm { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        public override string ToString() => $"{Name}\tx{Quantity}";
        
    }
}