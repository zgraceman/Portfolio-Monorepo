using System;
using System.Collections.Generic;

namespace InventoryManagementSystem.src
{

    public class Office
	{
        public int OfficeId { get; private set; }
        public string Name { get; private set; }
        public Inventory OfficeInventory { get; private set; }

        /// <summary>
        /// Initializes a new instance of the Office class with a specific name and ID.
        /// </summary>
        /// <param name="officeId">The unique identifier for the office.</param>
        /// <param name="name">The name of the office.</param>
        public Office(int officeId, string name)
        {
            OfficeId = officeId;
            Name = name;
            OfficeInventory = new Inventory();
        }
    }
}

