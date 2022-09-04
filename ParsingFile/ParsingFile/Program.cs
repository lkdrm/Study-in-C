using ParsingFile;

static void LinqMethods(string file)
{
    IEnumerable<Parsing> list = File.ReadAllLines(file)
        .Select(Parsing.ParseFide)
        // old version of anonim method
        //.Where(delegate(Parsing player) { return player.BirthYear > 1990 },
        .Where(player => player.BirthYear > 1960)
        .OrderByDescending(player => player.Rating)
        .Take(10)
        .ToList();

    Console.WriteLine($"The lowest  rating in TOP 10 : {list.Min(x => x.Rating)}");
    Console.WriteLine($"The highest rating in TOP 10 : {list.Max(x=>x.Rating)}");
    Console.WriteLine($"The average rating in TOP 10 : {list.Average(x=>x.Rating)}");

    Console.WriteLine(list.First());
    Console.WriteLine(list.Last());

    Console.WriteLine(list.First(player=>player.Country == " CZE"));

    var firstFromUSA = list.FirstOrDefault(player => player.Country == "USA");

    if (firstFromUSA != null)
    {
        Console.WriteLine(firstFromUSA.LastName);
    }
    else
    {
        Console.WriteLine("We did`t find anybody from USA...");
    }

    // or I can use single -- but if only one if more than one will exeption.
}

LinqMethods("D:\\Програми\\Visual_Code_C#\\ParsingFile\\ParsingFile\\top10.txt");


var list = new List<int> { 1,2,3 };
var query = list.Where(c => c >= 2).ToList();
list.Remove(3);

Console.WriteLine(query.Count());
foreach(var item in query)
{
    Console.WriteLine(item);
}

static void RemoveInForeach()
{
    var list2 = new List<int> { 0, 1, 2, 3, 4, 5 };
    foreach(var item in list2)
    {
        if(item %2 ==0)
        {
            list2.Remove(item);
        }
    }
    Console.WriteLine(list2.Count());
}
//RemoveInForeach();

static void RemoveInFor()
{
    var list3 = new List<int> { 0, 1, 2, 3, 4, 5 };

    for (var i = 0; i < list3.Count; i++)
    {
        var item = list3[i];
        if (item <=3)
        {
            list3.Remove(item);
            i--;
            Console.WriteLine(item);
        }
    }   
}
RemoveInFor();

static void FindAllPlayers()
{
    var players = File.ReadAllLines("D:\\Програми\\Visual_Code_C#\\ParsingFile\\ParsingFile\\Top100ChessPlayers.txt")
        .Select(Parsing.ParseFide)
        .Where(player => player.Country == "USA")
        .OrderBy(player => player.BirthYear)
        .ToList();

    foreach(var player in players)
    {
        Console.WriteLine($" Chess players from USA : {player}");
    }  
}
FindAllPlayers();
