using System;
using System.Threading;


public class Program
{
    static void Main(string[] args)
    {
        // Initialize the different activities
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectionActivity reflectionActivity = new ReflectionActivity();
        ListingActivity listingActivity = new ListingActivity();

        // Display the main menu and get the user's choice
        int choice = DisplayMainMenu();

        // Perform the chosen activity
        switch (choice)
        { 
            case 1:
                breathingActivity.Start();
                break;
            case 2:
                reflectionActivity.Start();
                break;
            case 3:
                listingActivity.Start();
                break;
            default:
                Console.WriteLine("Exiting program.");
                break;
        }

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }

    
        static int DisplayMainMenu()
        {
            Console.WriteLine("Welcome to the Mindfulness App");
            Console.WriteLine("Please choose an activity:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Quit");

            return int.Parse(Console.ReadLine());
        }
    

}