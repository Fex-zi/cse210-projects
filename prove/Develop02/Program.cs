using System;

public class Program
{
    static void Main(string[] args)
    {     
         journal NewJournal = new journal();
         int _answer = 0;
         Console.WriteLine("Choose a number from this given options: \n 1. Write\n 2. Display\n 3. Load File\n 4. Save\n 5. Exit");
         _answer = int.Parse(Consoaddle.ReadLine());

         if(_answer == 1)
         {
            NewJournal.AddToEntries();
         }
         else if (_answer == 2)
         {
            NewJournal.GetPrompt();
         }
         else if (_answer == 3)
         {
            Console.WriteLine("What is the Filename: ");
            string file = Console.ReadLine();
            NewJournal.Load(file);

         }
         else if (_answer == 4)
         {
            Console.WriteLine("What is the Filename: ");
            string Savefile = Console.ReadLine();
            NewJournal.Load(Savefile);

         }
         else if (_answer == 5)
         {
        
            Console.WriteLine("Thank you for your time.");
         }
         else
         {
            Console.WriteLine("Please pick a number.");
         }
         
    }

}