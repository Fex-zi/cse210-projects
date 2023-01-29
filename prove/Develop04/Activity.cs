using System;


public abstract class Activity
{
    protected string name;
    protected string description;
    protected int duration;

    public Activity(string _name, string _description)
    {
        name = _name;
        description = _description;
    }

    public void Start()
    {
        Console.WriteLine("Starting activity: " + name);
        Console.WriteLine(description);
        Console.WriteLine("How long would you like to do this activity for? (in seconds)");
        duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Prepare to begin in 5 seconds...");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i + "...");
            Thread.Sleep(1000);
        }

        Begin();
    }

    public void Finish()
    {
        Console.WriteLine("You've done a great job!");
        Thread.Sleep(3000);
        Console.WriteLine("You've completed the " + name + " activity for " + duration + " seconds.");
        Thread.Sleep(3000);
    }

    
    protected abstract void Begin();
}

