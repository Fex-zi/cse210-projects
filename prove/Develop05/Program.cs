using System;
using System.Collections.Generic;

namespace EternalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            int choice = 0;
            while (choice != 6)
            {
                Console.WriteLine("Eternal Quest");
                Console.WriteLine("1. Create new goal");
                Console.WriteLine("2. Record an event");
                Console.WriteLine("3. Display score");
                Console.WriteLine("4. Load Goals");
                Console.WriteLine("5. Save goals");
                Console.WriteLine("6. Exit");

                Console.WriteLine("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                         Console.WriteLine("Enter goal type (Simple, Eternal, Checklist):");
                        string goalType = Console.ReadLine();
                        user.AddGoal(goalType);
                        break;
                    case 2:
                        Console.WriteLine("Enter goal name: ");
                        string goalName = Console.ReadLine();
                        user.RecordEvent(goalName);
                        break;
                    case 3:
                        Console.WriteLine("Your score is: " + user.Score);
                        break;
                    case 4:
                        user.ShowGoals();
                        Console.WriteLine("Progress loaded.");
                        break;
                    case 5:
                        user.SaveGoals();
                        Console.WriteLine("Progress saved.");
                        break;
                    case 6:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please choose again.");
                        break;
                }
            }
        }
    }
}
