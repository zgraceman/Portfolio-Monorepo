using System;

namespace InventoryManagementSystem
{
    public class Device : Product
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }

        public Device() { }

        public Device(string name, string manufacturer, string model, decimal price)
            : base(name, price)
        {
            Manufacturer = manufacturer;
            Model = model;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Manufacturer: {Manufacturer}, Model: {Model}";
        }
    }
}

