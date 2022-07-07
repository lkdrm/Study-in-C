int x = 1;
int y = 2;

bool areEqual = x == y;
Console.WriteLine(areEqual);
// or
bool result = x > y;
Console.WriteLine(result);

result = x >= y;
Console.WriteLine(result);

result = x < y;
Console.WriteLine(result);

result = x <= y;
Console.WriteLine(result);

result = x != y;
Console.WriteLine(result);

static void IncrementDecrement()
{
    int x = 1;
    x = x + 1;
    Console.WriteLine(x);

    x++; // postfix
    ++x; // infix

    Console.WriteLine(x);

    x = x - 1;
    x--;
    --x;
    Console.WriteLine(x);


    Console.WriteLine("Learn about increments.");
    Console.WriteLine($"Last x state is {x}"); // Like f string in python.

    int j = x++;
    Console.WriteLine($"Now i console a j: {j}");
    Console.WriteLine($"Now i console a x: {x}");

    j = ++x; // priorit is +1 and than save.

    Console.WriteLine($"Now i console a j: {j}");
    Console.WriteLine($"Now i console a x: {x}");

    x += 2;
    Console.WriteLine($"x+=2: {x}");
}

static void MathOperations()
{
    int x = 1;
    int y = 2;

    int z = x + y;
    int k = x - y;
    int a = z + k - y;

    Console.WriteLine($"Call z: {z}");
    Console.WriteLine($"Call k: {k}");
    Console.WriteLine($"Call a: {a}");

    int b = z * 2;
    int c = k / 2;

    Console.WriteLine($"Call b: {b}");
    Console.WriteLine($"Call c: {c}");

    a = 4 % 2;
    b = 5 % 2;

    Console.WriteLine(a);
    Console.WriteLine(b);

    a = 3;
    a = a * a;
    Console.WriteLine(a);

    a = 2 + 2 * 2;
    Console.WriteLine($"The result is: {a}");


}