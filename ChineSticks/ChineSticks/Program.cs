using ChineSticks;

Random rnd = new Random();

StickGame game = new();

while (game.sticks != 0)
{
    int playerchoice = int.Parse(Console.ReadLine());
    game.choice(playerchoice);
    Console.WriteLine($"You take {playerchoice} sticks.");
    int PcChoice = rnd.Next(1, 4);
    game.choice(PcChoice);
    Console.WriteLine($"PC take {PcChoice} sticks.");
    Console.WriteLine($"Now is {game.sticks}");
}

