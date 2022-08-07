using OOP;

//Character a = new Character();

//a.hit(90);

//Console.WriteLine(a.health);

// Calculator c = new Calculator();
// c. 
// with method static my oop can`t change.
static void oopMath()
{
    double square1 = Calculator.CalcTriangleSquare(10, 20);
    double square2 = Calculator.CalcTriangleSquare(30, 20, 10);

    Console.WriteLine($"Square 1 is : {square1}. Square 2 is : {square2}");

    ArabicNumbers roman = new();

    string roman1 = roman.RomanNumbers("X");

    Console.WriteLine(roman1);

    double avg = Calculator.Average(new int[] { 1, 2, 3, 4 });

    Console.WriteLine($"The average of numbers is : {avg}");

    double avg2 = Calculator.Average2(1, 2, 3, 4);

    Console.WriteLine($"The average2 of numbers is : {avg2}");

    Console.WriteLine("Enter a number: ");

}

static void aboutParsing()
{

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


    if (Calculator.TryDivided(10, 5, out double result))
    {
        Console.WriteLine($"The result of divided two numbers is : {result}");
    }
    else
    {
        Console.WriteLine("Fall.");
    }
}

static void aboutCharacter()
{
    //Character c1 = new();
    //Character c2 = new();

    //Console.WriteLine($"The speed of player one is : {c1}..... The speed of player to is :{c2}");

    //c1.IncreaseSpeed();

    //Console.WriteLine($"The speed of player one is : {c1}..... The speed of player to is :{c2}");
    // To static arguments memory save only once.
}
// with optional value
/// double resultTriagle = Calculator.CalcTriagleSquare(10, 23, 45, true);
/// Console.WriteLine($"With optional parametr : {resultTriagle}");

static void classStructre()
{
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

}
////
static void aboutList()
{
    var list = new List<int>();
    addNumbers(list);

    foreach (var i in list)
    {
        Console.WriteLine(i);
    }

    static void addNumbers(List<int> numbrs)
    {
        numbrs.Add(1);
        numbrs.Add(2);
        numbrs.Add(3);
    }

}
// Swap (ref r, ref t)
static void funcSwap()
{
    int r = 3;
    int t = 7;

    Swap(r, t);

    Console.WriteLine($"a={r}, b={t}");

    // Swap ( ref a , ref b ) - will always be result same
    // as in func and out
    static void Swap(int a, int b)
    {
        Console.WriteLine($"Origin numb a={a}, b={b}");

        int tmp = a;
        a = b;
        b = tmp;

        Console.WriteLine($"Swapped numbers a={a}, b={b}");
    }
}

//
///Character c = new("Elven");
///Console.WriteLine(c.Race);
///

///ModelXTerminal terminal = new("Id124");
///terminal.Connect();

static void AboutInheritanceInterface()
{
    Shape[] shapes = new Shape[2];
    shapes[0] = new Triangle(5, 8, 12);
    shapes[1] = new Rectangle(8, 4);

    foreach (Shape shape in shapes)
    {
        shape.Draw();
        Console.WriteLine($"The perimeter is : {shape.Perimeter()}");
    }

    List<object> list = new() { 1, 2, 3 };

    IBaseCollection collection = new BaseList(10);
    collection.Add(1);
    collection.Add(2);
    collection.AddRange(list);
}

///Rect rect = new() { Height = 2, Width = 5};
///
///int rectArea = AreaCalculator.CalcSquare(rect);
///Console.WriteLine($"Rect area - {rectArea}");
///
// The problem of representitive.
///Rect square = new() { Height = 2, Width = 10};
///AreaCalculator.CalcSquare(square);
/// 
IShape rect = new Rect() { Height = 2, Width = 5};
IShape sqaure = new Square() { Sidelentgh = 10 };

Console.WriteLine($"Rect area - {rect.CalcSquare()}");
Console.WriteLine($"Square area - {sqaure.CalcSquare()}");