public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) 
        : base(name, description)
    {
    }

    protected override void ExecuteActivity()
    {
        Console.WriteLine("Clear your mind and focus on your breathing.");
        Console.WriteLine();

        Console.WriteLine("Starting in:");
        Countdown(3);
        Console.WriteLine();
        
        int cicles = duration / 5;
        
        while (cicles != 0)
            {
                Console.WriteLine("Breathe in...");
                Countup(5);
                cicles--;
                if (cicles > 0)
                {
                    Console.WriteLine("Breathe out...");
                    Countdown(5);
                    cicles--;
                }
            }
    }
}
