using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int chosenNumber = 1;
        Console.Write("Enter a list of numbers, type 0 when finished.");

        while (chosenNumber != 0)
        {
            Console.Write("Enter number: ");
            chosenNumber = int.Parse(Console.ReadLine());
            numbers.Add(chosenNumber);
        }
        float sum = 0;
        int largest = 0;

        for (int i = 0; i < numbers.Count; i++)
        {
            sum = sum + numbers[i];
            if (numbers[i] > largest)
            {
                largest = numbers[i];
            }
        }
        float average = sum / (numbers.Count - 1);

        Console.WriteLine($" ");
        Console.WriteLine($"The qtd is: {numbers.Count - 1} ");
        Console.WriteLine($"The sum is: {sum} ");
        Console.WriteLine($"The average is: {average:F5} ");
        Console.WriteLine($"The largest number is: {largest} ");
    }
}