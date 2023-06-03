using System;
using System.Collections.Generic;

class Scripture
{
    private Reference reference;
    private List<Word> words;

    public Scripture(Reference reference, string scriptureText)
    {
        this.reference = reference;
        words = new List<Word>();

        // Split the scripture text into individual words
        string[] wordArray = scriptureText.Split(' ');

        // Create Word objects for each word in the scripture
        foreach (string word in wordArray)
        {
            words.Add(new Word(word));
        }
    }

    public void HideRandomWord()
    {
        // Find a random word that is not already hidden
        Random random = new Random();
        List<Word> visibleWords = words.FindAll(word => !word.IsHidden);

        if (visibleWords.Count > 0)
        {
            int randomIndex = random.Next(visibleWords.Count);
            visibleWords[randomIndex].IsHidden = true;
        }
    }

    public bool IsFullyHidden()
    {
        foreach (Word word in words)
        {
            if (!word.IsHidden)
                return false;
        }
        return true;
    }

    public void Display()
    {
        Console.WriteLine(reference.ToString());
        foreach (Word word in words)
        {
            if (word.IsHidden)
            {
                string hiddenText = new string('-', word.Text.Length);
                Console.Write(hiddenText + " ");
            }
            else
            {
                Console.Write(word.Text + " ");
            }
        }
        Console.WriteLine();
    }
}
