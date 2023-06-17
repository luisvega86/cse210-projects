using System;
using System.Threading;

public abstract class Activity
{
    protected string name;
    protected string description;
    protected int duration;

    public Activity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public void Start(int duration)
    {
        this.duration = duration;
        DisplayStartingMessage();
        Pause(3);
        ExecuteActivity();
        DisplayEndingMessage();
    }

    protected virtual void ExecuteActivity()
    {
        // Placeholder implementation for base class
    }

    protected int GetDuration()
{
    Console.Write("Enter the duration (in seconds): ");
    string input = Console.ReadLine();

    if (int.TryParse(input, out int duration) && duration > 0)
    {
        return duration;
    }

    Console.WriteLine("Invalid duration. Please enter a positive integer.");
    return GetDuration();
}


    protected void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {name}...");
        Console.WriteLine(description);
        Console.WriteLine();
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine($"You have completed {name} for {duration} seconds.");
        Pause(3);
        Console.Clear();
    }

    protected void Pause(int seconds = 1)
    {
        Thread.Sleep(seconds * 1000);
    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
    protected void Countup(int seconds)
    {
        for (int i = 1; i <= seconds; i++)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
}

