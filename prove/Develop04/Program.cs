public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness App!");

        int choice;
        while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                if (choice == 0)
                {
                    break;
                }
                else if (choice >= 1 && choice <= 3)
                {
                    Console.Write("Enter the duration (in seconds): ");
                    if (int.TryParse(Console.ReadLine(), out int duration))
                    {
                        Activity activity;
                        switch (choice)
                        {
                            case 1:
                                activity = new BreathingActivity("Breathing Activity", "This activity will help you relax by guiding you through breathing in and out slowly.");
                                break;
                            case 2:
                                activity = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.");
                                break;
                            case 3:
                                activity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                                break;
                            default:
                                continue;
                        }
                        Console.Clear();
                        activity.Start(duration);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid duration.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid choice.");
            }
        }
    }
}
