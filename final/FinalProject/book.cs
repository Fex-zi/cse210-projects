using System;

public class Book : LibraryItem
{
    public string Author { get; set; }
    public string ISBN { get; set; }

    public override void Print()
    {
        Console.WriteLine("Book Title: " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("ISBN: " + ISBN);
    }
}