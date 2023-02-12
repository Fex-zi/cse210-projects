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

        public void PrintInventory()
        {
            Console.WriteLine("Inventory:");
            
        }
    }
