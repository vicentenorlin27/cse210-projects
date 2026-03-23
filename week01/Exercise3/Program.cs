using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creativity / Exceeding Requirements:
        // 1. This program uses a library of scriptures instead of only one.
        // 2. It randomly selects a scripture each time the program runs.
        // 3. It only hides words that are not already hidden.

        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his only Begotten Son, that whosoever believeth in him should not perish, but have everlasting life."
            ),
            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding. In all thy ways acknowledge him and he shall direct thy paths."
            ),
            new Scripture(
                new Reference("Mosiah", 2, 17),
                "When ye are in the service of your fellow beings ye are only in the service of your God."
            ),
            new Scripture(
                new Reference("Philippians", 4, 13),
                "I can do all things through Christ which strengthens me."
            )
        };

        Random random = new Random();
        Scripture selectedScripture = scriptures[random.Next(scriptures.Count)];

        while (!selectedScripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press Enter to continue or type 'quit' to finish: ");
            string input = Console.ReadLine();

            if (input != null && input.ToLower() == "quit")
            {
                break;
            }

            selectedScripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(selectedScripture.GetDisplayText());
        Console.WriteLine();
        Console.WriteLine("Program ended.");
    }
}