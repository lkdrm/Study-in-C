Random rnd = new Random();

int num = rnd.Next(10);

int tries = 0;

Console.WriteLine("The program has choose one number find it. You have 5 tries.");
Console.WriteLine("Write your number ");

while (tries != 5)
{
    int userNumber = int.Parse(Console.ReadLine());
    if(userNumber == num)
    {
        Console.WriteLine($"The number is : {num}");
        Console.WriteLine("You wins");
        break;
    }
    else if (userNumber > num)
    {
        Console.WriteLine("The number is less as you write now.");
        tries++;
    }
    else if (userNumber < num)
    {
        Console.WriteLine("The number is bigger as you write now.");
        tries++;
    }
    else
    {
        Console.WriteLine("You lose");
    }
}