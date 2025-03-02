using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("sample text");
        string name = Console.ReadLine();
        Console.WriteLine($"hi, {name}");

        Console.WriteLine("coinflip, type 'throw'");
        string input = Console.ReadLine();
        if (input == "throw")
        {
            Random random = new Random();
            string result = random.Next(2) == 0 ? "heads" : "tails";
            Console.WriteLine($"result: {result}");
        }
        else
        {
            Console.WriteLine("incorrect input");
        }
    }
}