using Base;

var game = new ChineSticks(10, Player.Player);

game.PlayerPlay += GamePlayer;
game.PcPlay += GamePcPlay;
game.EndOfGame += GameIsEnd;

game.Start();

void GameIsEnd(Player winner)
{
    Console.WriteLine($"The winner of this game is : {winner}"); 
}

void GamePcPlay(int PC)
{
    Console.WriteLine($"The Computer take:{PC}");
}

void GamePlayer(object? sender, int sticks)
{
    Console.WriteLine($"The stick remaining {sticks}");
    Console.WriteLine("Take sticks from 1 to 3 max");

    bool takeCorrectly = false;
    while (!takeCorrectly)
    {
        if(int.TryParse(Console.ReadLine(), out int takesticks))
        {
            var game = (ChineSticks)sender;
        }
        try
        {
            game.PlayerTake(takesticks);
            takeCorrectly = true;
        }
        catch(ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}