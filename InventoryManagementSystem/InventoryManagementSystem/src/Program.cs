using InventoryManagementSystem;
using System;

namespace InventoryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory(10);

            inventory.AddBook(new Book("1984", "George Orwell", 9.99m));
            inventory.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", 12.99m));

            Console.WriteLine("Current Inventory:");
            inventory.DisplayBooks();

            decimal convertedPrice = Utility.ConvertCurrency(10.00m, 1.2m);
            Console.WriteLine($"Converted Price: {convertedPrice}");
        }
    }
}

