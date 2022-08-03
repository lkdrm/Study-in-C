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

ArabicNumbers roman = new();

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

Character c1 = new();
Character c2 = new();

Console.WriteLine($"The speed of player one is : {c1}..... The speed of player to is :{c2}");

c1.IncreaseSpeed();

Console.WriteLine($"The speed of player one is : {c1}..... The speed of player to is :{c2}");
// To static arguments memory save only once.

double resultTriagle = Calculator.CalcTriagleSquare(10, 23, 45, true);

Console.WriteLine($"With optional parametr : {resultTriagle}");

PointVal a; // it`s same as like I`ll write -- PointVal a = new PointVal;

Console.WriteLine("With structure point value :");

a.X = 5;
a.Y = 8;

PointVal b = a;

b.X = 3;
b.Y = 9;

a.LogValue();
b.LogValue();
// Now with point ref:

Console.WriteLine("With reference point :");

PointRef d = new();

d.X = 2;
d.Y = 1;

PointRef f = d;

f.X = 7;
f.Y = 6;

d.LogValue();
f.LogValue();


////

var list = new List<int>();
addNumbers(list);

foreach(var i in list)
{
    Console.WriteLine(i);
}

static void addNumbers(List<int> numbrs)
{
    numbrs.Add(1);
    numbrs.Add(2);
    numbrs.Add(3);
}

int r = 3;
int t = 7;

Swap(r, t);

Console.WriteLine($"a={r}, b={t}");

static void Swap (int a, int b)
{
    Console.WriteLine($"Origin numb a={a}, b={b}");
    
    int tmp = a;
    a = b;
    b = tmp;

    Console.WriteLine($"Swapped numbers a={a}, b={b}");
}