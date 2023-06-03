using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Scripture Hider!");

        Console.Write("Enter the book: ");
        string book = Console.ReadLine();

        Console.Write("Enter the chapter: ");
        int chapter = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the start verse: ");
        int startVerse = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the end verse: ");
        int endVerse = Convert.ToInt32(Console.ReadLine());

        Reference reference = new Reference(book, chapter, startVerse, endVerse);

        Console.WriteLine("Enter the scripture content:");
        string scriptureContent = Console.ReadLine();

        Scripture scripture = new Scripture(reference, scriptureContent);

        ClearConsole();
        scripture.Display();        

        while (!scripture.IsFullyHidden())
        {
            Console.WriteLine();
            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input == "quit")
                break;

            scripture.HideRandomWord();

            ClearConsole();
            scripture.Display();
        }

        Console.WriteLine("Thank you for using the Scripture Hider!");
    }

    static void ClearConsole()
    {
        Console.Clear();
    }
}
