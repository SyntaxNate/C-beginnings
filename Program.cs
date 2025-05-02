using System;

class Program 
{
    static void Main(string[] args)
    {
                Console.WriteLine("Welcome to C#, my friend.");
                Console.Write("What is your name? ");
                string name = Console.ReadLine();

                Console.ReadLine();

                Console.WriteLine($"Nice to meet you, {name}! You're officially a C# developer.");

    }
}