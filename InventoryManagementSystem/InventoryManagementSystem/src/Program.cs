using InventoryManagementSystem;
using System;

namespace InventoryManagementSystem
{
    class Program
    {
        private static string filePathLoad = "/Users/zgraceman/Desktop/products.json";
        private static string filePathSave = "/Users/zgraceman/Desktop/test.json";

        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();

            inventory.LoadFromJson(filePathLoad);

            // Adding books
            inventory.AddProduct(new Book("1984", "George Orwell", 9.99m));
            inventory.AddProduct(new Book("To Kill a Mockingbird", "Harper Lee", 12.99m));

            // Adding devices
            inventory.AddProduct(new Device("Zach's Smart Watch", "Garmin", "Venu 2 Plus", 200m));
            inventory.AddProduct(new Device("Zach's Phone", "Google", "Pixel 6a", 400m));

            // Displaying
            Console.WriteLine("Current Inventory:\n");
            inventory.DisplayProducts();

            // Utility
            decimal convertedPrice = Utility.ConvertCurrency(10.00m, 1.2m);
            Console.WriteLine($"\nConverted Price: {convertedPrice}");

            // JSON
            inventory.SaveToJson(filePathSave);
        }
    }
}

