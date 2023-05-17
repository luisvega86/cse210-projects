using System;
using System.Text.Json.Serialization;

public class Entry
{
    [JsonPropertyName("prompt")]
    public string Prompt { get; set; }

    [JsonPropertyName("response")]
    public string Response { get; set; }

    [JsonPropertyName("date")]
    public DateTime Date { get; set; }

    public Entry(string prompt, string response, DateTime date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }

    public void WriteEntry(PromptGenerator promptGenerator)
    {
        Prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine("Prompt: " + Prompt);
        Console.Write("Enter your response: ");
        Response = Console.ReadLine();
        Date = DateTime.Now;
    }
}
