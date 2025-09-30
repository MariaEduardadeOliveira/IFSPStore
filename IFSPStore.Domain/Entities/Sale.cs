using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    internal class Sale : BaseEntity<int>
    {
        public Sale(int id, DateTime date, double totalValue, User user, Customer customer):base(id)
        {
            Date = date;
            TotalValue = totalValue;
            User = user;
            Customer = customer;
        }

        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public User User { get; set; }
        public Customer Customer { get; set; }
    }

    internal class SaleItem : BaseEntity<int>
    {
        public SaleItem(int id, Sale sale, Product product, int amount, double unitValue, double totalValue) : base(id)
        {
            Sale = sale;
            Product = product;
            Amount = amount;
            UnitValue = unitValue;
            TotalValue = totalValue;
        }
        public Sale Sale { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }
        public double UnitValue { get; set; }
        public double TotalValue { get; set; }
        
    }
}
