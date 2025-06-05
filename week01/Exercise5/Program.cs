using System;

class Program
{
    static void Main(string[] args)
    {
        Program.DisplayWelcome();
        string _name = Program.PromptUserName();
        int _number = Program.PromptUserNumber();
        Program.DisplayResult(_name, _number);
    }

    static void DisplayWelcome()
    {
        Console.Write("Welcome to the Programa! \n");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: \n");
        string _name = Console.ReadLine();
        return _name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: \n");
        int _favoriteNumber = int.Parse(Console.ReadLine());
        return _favoriteNumber;
    }

    static void DisplayResult(string name, int favoriteNumber)
    {
        string _name = name;
        int _favoriteNumber = favoriteNumber;

        Console.Write($"{_name}, the square of your number is {Math.Pow(_favoriteNumber, 2)} \n");
    }     
}