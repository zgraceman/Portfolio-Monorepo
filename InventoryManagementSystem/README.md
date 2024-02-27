# Inventory Management System

The Inventory Management System is a console-based application designed to manage and persist an inventory of products, including books and electronic devices. It demonstrates object-oriented programming principles, serialization to JSON and XML, and practical use of C# features.

## Features

- **Product Management**: Add books and devices to the inventory.
- **Display Inventory**: View the current inventory, organized by product type.
- **Data Persistence**: Save and load inventory data to and from JSON and XML files.
- **Currency Conversion Utility**: Convert currency values with a specified exchange rate.

## Usage

1. **Loading Existing Inventory (Optional)**: On startup, the program attempts to load an existing inventory from a specified JSON file path.

2. **Adding Products**: The program allows adding books and devices to the inventory with details such as name, price, author (for books), manufacturer, and model (for devices).

3. **Displaying Products**: The current inventory is displayed on the console, categorized into books and devices.

4. **Saving Inventory**:
   - **To JSON**: Inventory can be saved to a JSON file, preserving the state of the current inventory for future use.
   - **To XML**: Similarly, the inventory can also be saved to an XML file.

## Classes

- `Product`: Base class for inventory items, including common properties like name and price.
- `Book`: Inherits from `Product`, adding the author property.
- `Device`: Inherits from `Product`, adding manufacturer and model properties.
- `Inventory`: Manages the collection of products and provides methods for adding products, displaying the inventory, and saving/loading to/from JSON and XML.
- `Utility`: Contains utility methods, such as currency conversion.

## Serialization Details

- **JSON Serialization**: Utilizes `Newtonsoft.Json` for converting the inventory list to and from JSON format.
- **XML Serialization**: Implements `System.Xml.Serialization` to handle XML serialization, including support for polymorphic serialization of the `Product` subclasses (`Book` and `Device`).

## Setup and Running

Ensure you have .NET SDK installed on your machine. Clone the repository and navigate to the project directory in your terminal. Run the program using the `dotnet run` command. The file paths for loading and saving data are hardcoded for demonstration purposes and can be adjusted as needed.

## Dependencies

- Newtonsoft.Json: Used for JSON serialization and deserialization.
- System.Xml.Serialization: For XML data persistence.

## Contributing

Contributions are welcome. Please open an issue to discuss your ideas or submit a pull request.

## License

This project is licensed under the MIT License. See the LICENSE file for details.
