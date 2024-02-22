using InventoryManagementSystem;
using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

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

        public void SaveToJson(string filePath)
        {
            var jsonString = JsonConvert.SerializeObject(products, Formatting.Indented);
            File.WriteAllText(filePath, jsonString);
        }

        public void LoadFromJson(string filePath)
        {
            if (File.Exists(filePath))
            {
                var jsonString = File.ReadAllText(filePath);
                products = JsonConvert.DeserializeObject<List<Product>>(jsonString);
            }
        }
    }
}