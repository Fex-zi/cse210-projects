using System;

class Program
{
      static void Main(string[] args)
        {
            Library library = new Library();

            UserInteraction userInteraction = new UserInteraction();

            userInteraction.Start(library);

            
        }
        
}