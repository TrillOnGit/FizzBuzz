// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Give me a number:");
        var userSucc = int.TryParse(Console.ReadLine(), out int userNum);

        while (!userSucc)
        {
            Console.WriteLine("That's an invalid number. Try again.");
            userSucc = int.TryParse(Console.ReadLine(), out userNum);
        }
        if (userNum % 3 == 0 || userNum % 5 == 0)
        {
            Console.WriteLine($"{(userNum % 3 == 0 ? "Fizz" : "")}{(userNum % 5 == 0 ? "Buzz" : "")}");
        }
        else
        {
            Console.WriteLine($"{userNum}");
        }
    }
}