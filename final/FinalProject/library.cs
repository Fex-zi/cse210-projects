using System;


public abstract class LibraryItem
{
    public string Title { get; set; }
    public abstract void Print();
}

public class Library
{
    private List<LibraryItem> items = new List<LibraryItem>();

    public void AddBook(Book book)
    {
        items.Add(book);
    }

    public void AddMagazine(Magazine magazine)
    {
        items.Add(magazine);
    }

    public List<LibraryItem> GetInventory()
    {
        return items;
    }

    public void PrintInventory()
    {
        Console.WriteLine("Inventory:");
        foreach (LibraryItem item in items)
        {
            item.Print();
            Console.WriteLine();
        }
    }
}

public class LibraryInventory
    {
        private List<LibraryItem> items = new List<LibraryItem>();

        public void AddLibraryItem(LibraryItem item)
        {
            items.Add(item);
        }

        public void RemoveLibraryItem(LibraryItem item)
        {
            items.Remove(item);
        }
  
        public void PrintInventory()
        {
            Console.WriteLine("Inventory:");
            foreach (LibraryItem item in items)
            {
                item.Print();
                Console.WriteLine();
            }
        }
    }