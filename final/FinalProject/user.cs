using System;

 public class UserInteraction
    {
        public void Start(Library library)
        {
            while (true)
            {
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Add Magazine/ Not working yet");
                Console.WriteLine("3. Print Inventory");
                Console.WriteLine("4. Quit");
                Console.WriteLine();
                Console.Write("Enter your choice: ");
                

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Book book = new Book();
                        Console.Write("Enter Book title: ");
                        book.Title = Console.ReadLine();
                        Console.Write("Enter author: ");
                        book.Author = Console.ReadLine();
                        Console.Write("Enter ISBN: ");
                        book.ISBN = Console.ReadLine();
                        library.AddBook(book);
                        break;
                    case 2:
                       
                        break;
                    case 3:
                       // Console.WriteLine("This are the Inventories below");
                        library.PrintInventory();
                        break;
                    case 4:
                        return;
                }
                Console.WriteLine();
            }
        }
    }