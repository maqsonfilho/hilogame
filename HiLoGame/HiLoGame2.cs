namespace HiLoGame;

/// <summary>
/// At this version of HiLo Game the players make his guess one by one. 
/// If one find the MysteryNumber the game is over and we have only one winner.
/// </summary>
public class HiLoGame
{
    public int MysteryNumber { get; private set; }
    public int Min { get; private set; }
    public int Max { get; private set; }
    public List<Player> Players { get; private set; }
    public Random random { get; private set; }

    public HiLoGame(int min, int max)
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
            foreach (Player player in this.Players)
            {
                int guess = player.MakeGuess();

                if (guess == this.MysteryNumber)
                {
                    Console.WriteLine($"Player {player.Name} found the mystery number {this.MysteryNumber}! Congratulations!");
                    isMysteryNumberFound = true;
                    break;
                }
                else if (guess < this.MysteryNumber)
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