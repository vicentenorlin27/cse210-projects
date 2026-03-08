using System;

class Program
{
    // ask the user for their name
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name?");
        string firstName = Console.ReadLine();
        Console.WriteLine("What is your last name?");
        string lastName = Console.ReadLine();

// will display the user's full name
        Console.WriteLine($"Your name is {firstName}, {lastName}!");
    }
}

