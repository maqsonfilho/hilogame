using HiLoGame;


// Create a HiLoGame instance with a range of 1 to 100
HiLoGame.HiLoGame game = new HiLoGame.HiLoGame(1, 100);

// Add players to the game
game.AddPlayer(new Player("Player 1"));
game.AddPlayer(new Player("Player 2"));

// Start the game
game.StartGame();



// Create a HiLoGame instance with a range of 1 to 100
HiLoGame.HiLoGame2 game2 = new HiLoGame.HiLoGame2(1, 100);

// Add players to the game
game2.AddPlayer(new Player("Player 1"));
game2.AddPlayer(new Player("Player 2"));

// Start the game
game.StartGame();

Console.ReadLine();