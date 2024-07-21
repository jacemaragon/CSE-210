using System;
using System.Threading;

public abstract class BaseActivity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Duration { get; set; }

    public abstract void StartActivity();
    
    protected void EndActivity()
    {
        Console.WriteLine("Great job! You completed the " + Name + " activity.");
        Pause(3000);
    }

    protected void Pause(int milliseconds)
    {
        Console.WriteLine("...");
        DisplayAnimation(milliseconds);
    }

    protected void DisplayAnimation(int milliseconds)
    {
        for (int i = 0; i < milliseconds / 100; i++)
        {
            Console.Write("-");
            Thread.Sleep(100);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(100);
            Console.Write("\b \b");
            
        }
    }
}