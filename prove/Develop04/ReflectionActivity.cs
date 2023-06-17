public class ReflectionActivity : Activity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity(string name, string description) 
        : base(name, description)
    {
    }

    protected override void ExecuteActivity()
    {
        int cicles = duration / 10;
        Console.WriteLine("Starting in:");
        Countdown(3);
        Console.WriteLine();
        
        Console.WriteLine("Clear your mind and focus on your past experiences.");
        Pause(3);
        Console.WriteLine();

        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        Pause(3);
        Console.WriteLine();

        while (cicles != 0) 
        {
            string question = GetRandomQuestion();
            Console.WriteLine($"{question}");
            SpinnerAnimation(10);
            Console.WriteLine();
            cicles--;
        }
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Length);
        return prompts[index];
    }
    private string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(questions.Length);
        return questions[index];
    }

    private void SpinnerAnimation(int duration)
    {
        for (int i = 0; i < duration; i++)
        {
            string[] spinnerFrames = { "|", "/", "-", "\\" };
            string frame = spinnerFrames[i % spinnerFrames.Length];
            Console.Write($"{frame}");
            Pause(1);
            Console.Write("\b \b");
        }
    }
}

