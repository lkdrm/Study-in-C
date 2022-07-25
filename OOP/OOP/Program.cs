using OOP;

//Character a = new Character();

//a.hit(90);

//Console.WriteLine(a.health);

Calculator calc = new Calculator();
double square1 = calc.CalcTriangleSquare(10, 20);
double square2 = calc.CalcTriangleSquare(30, 20, 10);

Console.WriteLine($"Square 1 is : {square1}. Square 2 is : {square2}");

ArabicNumbers roman = new ArabicNumbers();

string roman1 = roman.RomanNumbers("X");

Console.WriteLine(roman1);
