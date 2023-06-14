namespace HiLoGame;

/// <summary>
/// At this version the players make his guesses simultaneously. 
/// If more than one player found the number they will be winners.
/// Can be more than one winner.
/// </summary>
public class HiLoGame2
{
    public int MysteryNumber { get; private set; }
    public int Min { get; private set; }
    public int Max { get; private set; }
    public List<Player> Players { get; private set; }
    public Random random { get; private set; }

    public HiLoGame2(int min, int max)
    {
        this.Min = min;
        this.Max = max;
        random = new Random();
        Players = new List<Player>();
    }

    public void AddPlayer(Player player)
    {
        this.Players.Add(player);
    }

    public void StartGame()
    {
        bool isMysteryNumberFound = false;
        this.MysteryNumber = random.Next(Min, Max + 1);

        Console.WriteLine("----- Hi-Lo Game -----");
        Console.WriteLine($"Guess a number between {Min} and {Max}.");

        while (!isMysteryNumberFound)
        {
            List<int> guesses = new List<int>();

            for (int i = 0; i < Players.Count; i++)
            {
                Player player = Players[i];
                int guess = player.MakeGuess();
                guesses.Add(guess);
            }

            Console.WriteLine("\n--- Results ---");

            for (int i = 0; i < Players.Count; i++)
            {
                Player player = Players[i];
                int guess = guesses[i];

                if (guess == this.MysteryNumber)
                {
                    Console.WriteLine($"Player {player.Name} found the mystery number {this.MysteryNumber}! Congratulations!");
                    isMysteryNumberFound = true;
                    break;
                }
                else if (guess < MysteryNumber)
                {
                    Console.WriteLine($"Player {player.Name}: HI");
                }
                else
                {
                    Console.WriteLine($"Player {player.Name}: LO");
                }
            }
        }
    }
}