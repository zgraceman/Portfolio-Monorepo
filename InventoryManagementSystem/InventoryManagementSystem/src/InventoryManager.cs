using System;
namespace InventoryManagementSystem
{
	public class InventoryManager
	{
        private Inventory inventory;

        public InventoryManager(Inventory inventory)
        {
            this.inventory = inventory;
        }

        public void LoadInventory(string jsonPath, string xmlPath)
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

        public void AddSampleProducts()
        {
            inventory.AddProduct(new Book("1984", "George Orwell", 9.99m));
            inventory.AddProduct(new Book("To Kill a Mockingbird", "Harper Lee", 12.99m));
            inventory.AddProduct(new Device("Zach's Smart Watch", "Garmin", "Venu 2 Plus", 200m));
            inventory.AddProduct(new Device("Zach's Phone", "Google", "Pixel 6a", 400m));
            Console.WriteLine("Sample products added.");
        }

        public void DisplayInventory()
        {
            Console.WriteLine("Current Inventory:\n");
            inventory.DisplayProducts();
        }

        public void SaveInventory(string jsonPath, string xmlPath)
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

