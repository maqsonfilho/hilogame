namespace HiLoGame;

public class Player
{
    public string Name { get; private set; }

    public Player(string name)
    {
        Name = name;
    }

    public int MakeGuess()
    {
        Console.Write($"[{this.Name}] Enter your guess: ");
        string input = Console.ReadLine();
        int guess;
        while (!int.TryParse(input, out guess))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            Console.Write($"[{this.Name}] Enter your guess: ");
            input = Console.ReadLine();
        }
        return guess;
    }
}