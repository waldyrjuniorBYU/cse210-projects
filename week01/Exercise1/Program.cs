using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string _firstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        string _lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {_lastName}, {_firstName} {_lastName}.");     
    }
}