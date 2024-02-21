using System;

namespace InventoryManagementSystem
{
	public class Book : Product
{
    public string Author { get; set; }

    public Book(string title, string author, decimal price)
        : base(title, price)
    {
        Author = author;
    }

    public override string ToString()
    {
            return $"Title: {Name}, Price: {Price}, Author: {Author}";
        }
}
}

