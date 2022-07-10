// 1 task :
// Make a input & user write his/her name 
// And the programm wil write hello {name}.
static void firstTask()
{
    Console.WriteLine("Hello enter below please your name :");

    string userName = Console.ReadLine();
    Console.WriteLine($"Hello {userName}");
}

// 2 task :
// Make user to write 2 digits & save like var1 & var2 console this variable 
// than change str1 to str2
// and console it.
static void secondTask()
{
    Console.WriteLine("Write here your first integer :");
    int a = int.Parse(Console.ReadLine());// 2

    Console.WriteLine("Write here your second integer :");
    int b = int.Parse(Console.ReadLine());// 3
    Console.WriteLine($"Your first integer is a={a}, your second integer is b={b}");

    int c = a;
    a = b;
    b = c;
    Console.WriteLine($"Your first integer is a={a}, your second integer is b={b}");
}

// 3 task :
// The user enter a integer like 123 , have 3. and a program input how much integers are in the var
static void findLandOfnumb()
{
    Console.WriteLine("Enter below your integer :");
    string a = Console.ReadLine();

    Console.WriteLine($"This number have {a.Length} integer.");
    // Or 

    Console.WriteLine("Enter below your integer :");
    int number = int.Parse(Console.ReadLine());

    Console.WriteLine($"This number number have {number.ToString().Length}");
}

// 4 task :
// Find S of a triangle, use a Geron`s formula.
static void GeronsFormula()
{
    // S = sqrt (p*(p-a)*(p-b)*(p-c)
    // p = (a+b+c)/2
    Console.WriteLine("This program will find out a S of a trigle by using a Geron`s formula.");

    Console.WriteLine("Enter please a first value: ");
    float a = float.Parse(Console.ReadLine());
    Console.WriteLine("Enter please a second value: ");
    float b = float.Parse(Console.ReadLine());
    Console.WriteLine("Enter please a third value: ");
    float c = float.Parse(Console.ReadLine());

    double p = (a + b + c) / 2;

    double S = Math.Sqrt(p * ((p - a) * (p - b) * (p - c)));

    Console.WriteLine($"The square is {Math.Round(S)}");
}

// 5 task:
/* The user must to write :
 *  Name , Last name, Age, Weight, Height.
 *  Count his index of body : weight/(Height*Height)
 *  The output must be :
 *  Your profile :
 *  Full name : Name , Last name.
 *  Age : Age,
 *  Weight : Weight,
 *  Height : Height,
 *  Body Mass Index : BMI.
 */

Console.WriteLine("We will create your profile");

Console.WriteLine("Enter your First name:");
string firstName = Console.ReadLine();

Console.WriteLine("Enter your Last name:");
string lastName = Console.ReadLine();

Console.WriteLine("Enter your age:");
int age = int.Parse(Console.ReadLine());

Console.WriteLine("Enter your weight:");
int weight = int.Parse(Console.ReadLine());

Console.WriteLine("Enter your height in meters:");
double height = double.Parse(Console.ReadLine());

double bodyMassIndex = weight / (height * height);

string profile =
    $"Your profile:\n"
   + $"Full name: {lastName} {firstName}\n"
   + $"Age: {age}\n"
   + $"Weight: {weight}\n"
   + $"Height: {height}\n"
   + $"Body Mass Index: {bodyMassIndex}";

Console.WriteLine(profile);