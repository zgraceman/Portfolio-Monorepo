using InventoryManagementSystem;
using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace InventoryManagementSystem
{
    /// <summary>
    /// Manages a collection of products within the inventory, including books and devices.
    /// Provides functionality to add products, display products, and save/load the inventory to/from JSON and XML.
    /// </summary>
    public class Inventory
    {
        private List<Product> products;
        private Dictionary<Type, string> productTypeNames;

        /// <summary>
        /// Initializes a new instance of the Inventory class.
        /// </summary>
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

        /// <summary>
        /// Displays the products in the inventory, grouped by type.
        /// </summary>
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

        /// <summary>
        /// Saves the current state of the inventory to a JSON file.
        /// </summary>
        /// <param name="filePath">The file path where the JSON file will be saved.</param>
        public void SaveToJson(string filePath)
        {
            var jsonString = JsonConvert.SerializeObject(products, Formatting.Indented);
            File.WriteAllText(filePath, jsonString);
        }

        /// <summary>
        /// Loads the inventory from a JSON file.
        /// </summary>
        /// <param name="filePath">The file path of the JSON file to be loaded.</param>
        public void LoadFromJson(string filePath)
        {
            if (File.Exists(filePath))
            {
                var jsonString = File.ReadAllText(filePath);
                products = JsonConvert.DeserializeObject<List<Product>>(jsonString);
            }
        }

        /// <summary>
        /// Saves the current state of the inventory to an XML file.
        /// </summary>
        /// <param name="filePath">The file path where the XML file will be saved.</param>
        public void SaveToXml(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, products);
            }
        }
    }
}