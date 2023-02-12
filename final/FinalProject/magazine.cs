using System;

public class Magazine : LibraryItem
{
    public int IssueNumber { get; set; }
    public DateTime PublicationDate { get; set; }

    public override void Print()
    {
       
    }
}