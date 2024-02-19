using InventoryManagementSystem;

namespace InventoryManagementSystem
{
    public class Inventory
    {
        private Book[] books;
        private int count;

        public Inventory(int size)
        {
            books = new Book[size];
            count = 0;
        }

        public void AddBook(Book book)
        {
            if (count < books.Length)
            {
                books[count] = book;
                count++;
            }
        }

        public void DisplayBooks()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(books[i]);
            }
        }
    }
}
