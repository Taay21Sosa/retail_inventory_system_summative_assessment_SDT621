using System;

class ProgarmStructureDemo
{
    static void Main(string[] args)
    {
        // Programs welcome message
        Console.WriteLine("Welcome to the Structure of a C# Program Demo!");

        // Prompt user to enter a students name
        Console.Write("Enter students name: ");

        // Variable to store student name
        string username = Console.ReadLine();

        // Prints the username
        Console.WriteLine($"Hello {username}!");

        // Prints the programs structure
        Console.WriteLine("\n1. using System : imports functionality");
        Console.WriteLine("2. namespace : organizes code");
        Console.WriteLine("3. class ProgarmStructureDemo  : container for code");
        Console.WriteLine("4. Main()  : entry point for code");
        Console.WriteLine("5. Comments  : explain logic and documentation");
    }
}
