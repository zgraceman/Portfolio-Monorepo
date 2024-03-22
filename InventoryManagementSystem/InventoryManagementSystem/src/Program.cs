using InventoryManagementSystem;
using System;

namespace InventoryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            string filePathLoadJson = "/Users/zgraceman/Desktop/products2.json";
            string filePathLoadXml = "/Users/zgraceman/Desktop/test.xml";
            string filePathSaveJson = "/Users/zgraceman/Desktop/out.json";
            string filePathSaveXml = "/Users/zgraceman/Desktop/out.xml";

            // Display menu to user
            DisplayMenu();
            bool running = true;
            while (running)
            {
                Console.Write("Select an option: ");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        LoadInventory(inventory, filePathLoadJson, filePathLoadXml);
                        break;
                    case "2":
                        AddSampleProducts(inventory);
                        break;
                    case "3":
                        DisplayInventory(inventory);
                        break;
                    case "4":
                        SaveInventory(inventory, filePathSaveJson, filePathSaveXml);
                        break;
                    case "5":
                        running = false;
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        DisplayMenu();
                        break;
                }
            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine("\nInventory Management System");
            Console.WriteLine("1. Load Inventory");
            Console.WriteLine("2. Add Sample Products");
            Console.WriteLine("3. Display Inventory");
            Console.WriteLine("4. Save Inventory");
            Console.WriteLine("5. Exit");
        }

        static void LoadInventory(Inventory inventory, string jsonPath, string xmlPath)
        {
            // Provide option to choose between JSON or XML
            Console.Write("Load from (1) JSON or (2) XML? ");
            string loadOption = Console.ReadLine();
            if (loadOption == "1")
            {
                inventory.LoadFromJson(jsonPath);
                Console.WriteLine("Inventory loaded from JSON.");
            }
            else if (loadOption == "2")
            {
                inventory.LoadFromXml(xmlPath);
                Console.WriteLine("Inventory loaded from XML.");
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }
        }

        static void AddSampleProducts(Inventory inventory)
        {
            // Sample products added as before
            inventory.AddProduct(new Book("1984", "George Orwell", 9.99m));
            inventory.AddProduct(new Book("To Kill a Mockingbird", "Harper Lee", 12.99m));
            inventory.AddProduct(new Device("Zach's Smart Watch", "Garmin", "Venu 2 Plus", 200m));
            inventory.AddProduct(new Device("Zach's Phone", "Google", "Pixel 6a", 400m));
            Console.WriteLine("Sample products added.");
        }

        static void DisplayInventory(Inventory inventory)
        {
            Console.WriteLine("Current Inventory:\n");
            inventory.DisplayProducts();
        }

        static void SaveInventory(Inventory inventory, string jsonPath, string xmlPath)
        {
            // Provide option to choose between JSON or XML
            Console.Write("Save as (1) JSON or (2) XML? ");
            string saveOption = Console.ReadLine();
            if (saveOption == "1")
            {
                inventory.SaveToJson(jsonPath);
                Console.WriteLine("Inventory saved to JSON.");
            }
            else if (saveOption == "2")
            {
                inventory.SaveToXml(xmlPath);
                Console.WriteLine("Inventory saved to XML.");
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }
        }
    }
}
