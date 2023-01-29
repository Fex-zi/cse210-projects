using System;
using System.Threading;


public class ListingActivity : Activity
{

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {

    }
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    

    protected override void Begin()
    {
        base.Start();
        string prompt = prompts[new Random().Next(0, prompts.Length)];
        Console.WriteLine(prompt);
        Console.WriteLine("You have " + duration + " seconds to start listing");
        Thread.Sleep(duration*1000);
        Console.WriteLine("Start listing!");
        int counter = 0;
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "") break;
            counter++;
        }
        Console.WriteLine("You've listed " + counter + " items.");
    }

    
   
}
