using TicTacToeGame;
using System.Text;
class Program
{
    private static TicTacToeClass game = new();

    static void Main(string[] args)
    {
        Console.WriteLine(GetPrintState());

        while(game.GetWinner() == Winner.GameUnFinished)
        {
            Console.WriteLine("Your turn ");
            int index = int.Parse(Console.ReadLine());
            game.MakeMove(index);

            Console.WriteLine();
            Console.WriteLine(GetPrintState());
        }
        Console.WriteLine($"The winner is : {game.GetWinner()}");
        Console.WriteLine();
    }

    static string GetPrintState()
    {
        var strBuild = new StringBuilder();
        for(int i=1; i<=7; i += 3)
        {
            strBuild.AppendLine("     |     |    |")
                .AppendLine($"  {GetPrintChar(i)}  |  {GetPrintChar(i + 1)}  |  {GetPrintChar(i + 2)} |")
                .AppendLine("_____|_____|____|");
        }
        return strBuild.ToString();
    }

    static string GetPrintChar(int index)
    {
        State state = game.GetState(index);
        if (state == State.Unset)
        {
            return index.ToString();
        }
        return state == State.Cross ? "X" : "0";
        
    }
}