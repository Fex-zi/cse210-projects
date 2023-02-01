using System;
using System.Threading; 

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    { }

    protected override void Begin()
    {
        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(3000);
            Console.WriteLine("Breathe out...");
            Thread.Sleep(3000);
        }

        Finish();
    }
}
