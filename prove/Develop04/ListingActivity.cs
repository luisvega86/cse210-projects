public class ListingActivity : Activity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description) 
        : base(name, description)
    {
    }

    protected override void ExecuteActivity()
    {
        Console.WriteLine("Starting in:");
        Countdown(3);
        Console.WriteLine();
        Console.WriteLine("Clear your mind and focus on the prompt.");
        Console.WriteLine();

        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.WriteLine();

        Console.WriteLine("Think for a moment...");
        Pause(3);
        

        Console.WriteLine("Start listing:");
        int count = ItemListing(duration);
        Console.WriteLine($"You listed {count} items.");
        Pause(5);
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Length);
        return prompts[index];
    }

    private int ItemListing(int duration)
    {
        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                count++;
            }
        }

        return count;
    }
}

