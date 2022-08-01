using OOP;

//Character a = new Character();

//a.hit(90);

//Console.WriteLine(a.health);

// Calculator c = new Calculator();
// c. 
// with method static my oop can`t change.

double square1 = Calculator.CalcTriangleSquare(10, 20);
double square2 = Calculator.CalcTriangleSquare(30, 20, 10);

Console.WriteLine($"Square 1 is : {square1}. Square 2 is : {square2}");

ArabicNumbers roman = new ArabicNumbers();

string roman1 = roman.RomanNumbers("X");

Console.WriteLine(roman1);

double avg = Calculator.Average(new int[] {1,2,3,4});

Console.WriteLine($"The average of numbers is : {avg}");

double avg2 = Calculator.Average2(1, 2, 3, 4);

Console.WriteLine($"The average2 of numbers is : {avg2}");

Console.WriteLine("Enter a number: ");

string line = Console.ReadLine();

bool wasParsed = int.TryParse(line, out int number);
if (wasParsed)
{
    Console.WriteLine(number);
}
else
{
    Console.WriteLine("Write a number. Not string.");

}


if( Calculator.TryDivided(10,5, out double result))
{
    Console.WriteLine($"The result of divided two numbers is : {result}");
}
else
{
    Console.WriteLine("Fall.");
}

Character c1 = new Character();
Character c2 = new Character();

Console.WriteLine($"The speed of player one is : {c1}..... The speed of player to is :{c2}");

c1.IncreaseSpeed();

Console.WriteLine($"The speed of player one is : {c1}..... The speed of player to is :{c2}");
// To static arguments memory save only once.