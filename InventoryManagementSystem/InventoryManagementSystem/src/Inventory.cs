using InventoryManagementSystem;

namespace InventoryManagementSystem
{
    public class Inventory
    {
        private Product[] products;
        private int count;

        public Inventory(int size)
        {
            products = new Product[size];
            count = 0;
        }

        public void AddProduct(Product product)
        {
            if (count < products.Length)
            {
                products[count] = product;
                count++;
            }
        }

        public void DisplayProducts()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(products[i]);
            }
        }
    }
}
