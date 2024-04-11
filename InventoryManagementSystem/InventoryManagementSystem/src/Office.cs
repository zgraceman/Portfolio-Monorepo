using System;
using System.Collections.Generic;

namespace InventoryManagementSystem.src
{

    public class Office
	{
        public string Name { get; private set; }
        public Inventory OfficeInventory { get; private set; }

        /// <summary>
        /// Initializes a new instance of the Office class with a specific name.
        /// </summary>
        /// <param name="name">The name of the office.</param>
        public Office(string name)
        {
            Name = name;
            OfficeInventory = new Inventory();
        }
    }
}

