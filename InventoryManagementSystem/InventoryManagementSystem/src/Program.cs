using InventoryManagementSystem;
using System;

namespace InventoryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory(10);

            inventory.AddProduct(new Book("1984", "George Orwell", 9.99m));
            inventory.AddProduct(new Book("To Kill a Mockingbird", "Harper Lee", 12.99m));
            // You can add other product types here as well

            Console.WriteLine("Current Inventory:");
            inventory.DisplayProducts();

            decimal convertedPrice = Utility.ConvertCurrency(10.00m, 1.2m);
            Console.WriteLine($"Converted Price: {convertedPrice}");
        }
    }
}

