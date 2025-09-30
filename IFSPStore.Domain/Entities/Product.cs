using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    internal class Product : BaseEntity<int>
    {
        public Product(int id, string name, double price, int amount, DateTime saleDate, string saleUnit, Category category):base(id)
        {
            Name = name;
            Price = price;
            Amount = amount;
            SaleDate = saleDate;
            SaleUnit = saleUnit;
            Category = category;
        }

        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        public DateTime SaleDate { get; set; }
        public string SaleUnit { get; set; }

        public Category Category { get; set; }
    }
}
