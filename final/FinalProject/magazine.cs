
using System;

public class Magazine : LibraryItem
{
    public int IssueNumber { get; set; }
    public DateTime PublicationDate { get; set; }

    public override void Print()
    {
        Console.WriteLine("Magazine Title: " + Title);
        Console.WriteLine("Issue number: " + IssueNumber);
        Console.WriteLine("Publication date: " + PublicationDate.ToShortDateString());
    }
}