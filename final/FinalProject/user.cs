using System;

public class UserInput
{
    public int GetChoice()
    {
        Console.WriteLine("1. Add Book");
        Console.WriteLine("2. Add Magazine");
        Console.WriteLine("3. Print Inventory");
        Console.WriteLine("4. Quit");
        Console.WriteLine();
        Console.Write("Enter your choice: ");
        int choice = int.Parse(Console.ReadLine());
        return choice;
    }

    public Book GetBookDetails()
    {
        Book book = new Book();
        Console.Write("Enter Book title: ");
        book.Title = Console.ReadLine();
        Console.Write("Enter author: ");
        book.Author = Console.ReadLine();
        Console.Write("Enter ISBN: ");
        book.ISBN = Console.ReadLine();
        return book;
    }

    public Magazine GetMagazineDetails()
    {
        Magazine magazine = new Magazine();
        Console.Write("Enter Magazine title: ");
        magazine.Title = Console.ReadLine();
        Console.Write("Enter issue number: ");
        Console.Write("Enter publication date (mm/dd/yyyy): ");
        magazine.PublicationDate = DateTime.Parse(Console.ReadLine());
        return magazine;
    }
}

public class UserChoice
{
    private UserInput input;
    private Library library;

    public UserChoice(UserInput input, Library library)
    {
        this.input = input;
        this.library = library;
    }

    public void Start(UserOutput output)
    {
        while (true)
        {
            int choice = input.GetChoice();

            switch (choice)
            {
                case 1:
                    Book book = input.GetBookDetails();
                    library.AddBook(book);
                    break;
                case 2:
                    Magazine magazine = input.GetMagazineDetails();
                    library.AddMagazine(magazine);
                    break;
                case 3:
                    output.PrintInventory(library.GetInventory());
                    break;
                case 4:
                    return;
            }
        }
    }
}

public class UserOutput
{
    public void PrintInventory(List<LibraryItem> items)
    {
        Console.WriteLine("Inventory:");
        foreach (LibraryItem item in items)
        {
            item.Print();
            Console.WriteLine();
        }
    }
}