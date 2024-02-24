using System.Xml.Serialization;

namespace InventoryManagementSystem
{
    [XmlInclude(typeof(Book))]
    [XmlInclude(typeof(Device))]
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product() {}

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Price: ${Price}";
        }
    }
}