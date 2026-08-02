using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by guiding you through slow breathing exercises.")
    {
    }

    protected override void PerformActivityLogic()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < futureTime)
        {
            Console.Write("\nInhale deeply... ");
            ShowCountDown(4);
            
            if (DateTime.Now >= futureTime) break;

            Console.Write("\nExhale slowly... "); 
            ShowCountDown(5); 
        }
    }
}