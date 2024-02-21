using InventoryManagementSystem;
using System;
using System.Collections.Generic;

namespace InventoryManagementSystem
{
    public class Inventory
    {
        private List<Product> products;
        private Dictionary<Type, string> productTypeNames;

        public Inventory()
        {
            products = new List<Product>();
            productTypeNames = new Dictionary<Type, string>
            {
                { typeof(Book), "Books" },
                { typeof(Device), "Devices" }
            };
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void DisplayProducts()
        {
            foreach (var pair in productTypeNames)
            {
                Console.WriteLine($"{pair.Value}:");
                foreach (var product in products)
                {
                    if (product.GetType() == pair.Key)
                    {
                        Console.WriteLine($" - {product}");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}