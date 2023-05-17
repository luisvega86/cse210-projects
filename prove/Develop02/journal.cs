using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

public class Journal
{
    [JsonPropertyName("_entries")]
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
        }
        else
        {
            Console.WriteLine("Journal Entries:");
            foreach (var entry in _entries)
            {
                Console.WriteLine($"Date: {entry.Date}");
                Console.WriteLine($"Prompt: {entry.Prompt}");
                Console.WriteLine($"Response: {entry.Response}");
                Console.WriteLine();
            }
        }
    }

    public void SaveToFile(string fileName)
    {
        try
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(_entries, options);
            File.WriteAllText(fileName, json);
            Console.WriteLine("Journal saved to file successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error occurred while saving the journal: " + ex.Message);
        }
    }

    public void LoadFromFile(string fileName)
    {
        try
        {
            if (File.Exists(fileName))
            {
                string json = File.ReadAllText(fileName);
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };
                _entries = JsonSerializer.Deserialize<List<Entry>>(json, options);
                Console.WriteLine("Journal loaded from file successfully.");
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error occurred while loading the journal: " + ex.Message);
        }
    }
}
