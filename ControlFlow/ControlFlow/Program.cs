static void aboutIf()
{
    Console.WriteLine("What`s you age?");
    int age = int.Parse(Console.ReadLine());

    Console.WriteLine("What`s your weight ?");
    double weight = double.Parse(Console.ReadLine());

    Console.WriteLine("What`s your height in meters?");
    double height = double.Parse(Console.ReadLine());

    double bodyMassIndex = weight / (height * height);

    bool isTooLow = bodyMassIndex <= 18.5;
    bool isNormal = bodyMassIndex > 18.5 && bodyMassIndex < 25;
    bool isAboveNormal = bodyMassIndex >= 25 && bodyMassIndex <= 30;
    bool isHighFat = bodyMassIndex > 30;

    bool isFat = isAboveNormal || isHighFat;

    // is True
    if (isFat)
    {
        Console.WriteLine("You`d better lose some weight.");
    }
    else
    {
        Console.WriteLine("You`re in a good condition.");
    }

    // is False
    if (!isFat)
    {
        Console.WriteLine("Your not fat.");
    }

    if (isTooLow)
    {
        Console.WriteLine("Not enough weight.");
    }
    else if (isNormal)
    {
        Console.WriteLine("You`re Ok");
    }
    else if (isAboveNormal)
    {
        Console.WriteLine("Be careful.");
    }
    else
    {
        Console.WriteLine("You need to lose some weight.");
    }

    if (isFat || isHighFat)
    {
        Console.WriteLine("Time to get on diet.");
    }

    // Ternar operation:
    string description = age > 18 ? "You can drink alcohol" : "You should be older!";
    Console.WriteLine(description);
}
// Task:
// The user must to write a two values & find a max and min.
static void firstTask()
{
    Console.WriteLine("Here we will a maximum and minimum of two values.");

    Console.WriteLine("Enter your first value :");
    int a = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter your second value :");
    int b = int.Parse(Console.ReadLine());

    if (a > b)
    { Console.WriteLine($"The first value is max {a}."); }
    else
    { Console.WriteLine($"The second value is max {b}."); }
}

static void forCycle()
{
    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    //Increment
    Console.WriteLine("Increment : ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();

    //Decrement
    Console.WriteLine("Decrement : ");
    for (int i = numbers.Length - 1; i >= 0; i--)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();

    //Only numbers % 2
    Console.WriteLine("Numbers == 2 :");
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        { Console.Write(numbers[i] + " "); }
    }
    Console.WriteLine();

    //Only numbers % 3
    Console.WriteLine("Numbers == 3 :");
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 1)
        { Console.Write(numbers[i] + " "); }
    }
    // or i can use foreach
    Console.WriteLine("\nForeach");
    foreach (int i in numbers)
    {
        Console.Write(i + " ");
    }
}

static void pairsAndTriplets()
{
    int[] numbers = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };
    // Circle where we go to find a sum from 2 numbers which gave us sum == 0
    // First take number = 1 index = 0 
    Console.WriteLine("The sum of two numbers which gave me a zero.\n");
    for (int i = 0; i < numbers.Length; i++)
    {// Here start from index 1 take number = -2 index = 1
        for (int j = i + 1; j < numbers.Length; j++)
        {
            int aI = numbers[i];
            int bJ = numbers[j];
            // count a sum if a + b = 0 
            if (aI + bJ == 0)
            {// if true tell which numbers and his index.
                Console.WriteLine($"The sum of two numbers - ({aI};{bJ}). Indexes :({i};{j})");
            }
        }
    }
    Console.WriteLine();
    Console.WriteLine("The sum of three numbers which gave me a zero.\n");
    for (int i = 0; i < numbers.Length - 2; i++)
    {
        for (int j = i + 1; j < numbers.Length - 1; j++)
        {
            for (int k = j + 1; k < numbers.Length; k++)
            {
                int aI = numbers[i];
                int bJ = numbers[j];
                int cK = numbers[k];

                if (aI + bJ + cK == 0)
                {
                    Console.WriteLine($"The sum of three numbers - ({aI};{bJ};{cK}). Indexes : ({i};{j};{k})");
                }
            }
        }
    }
}


static void doWhileDo()
{
    int age = 30;

    int age2 = 0;

    while (age2 < 18)
    {
        Console.WriteLine("First whie loop.");
        Console.WriteLine("What is your age?");
        age = int.Parse(Console.ReadLine());
    }
    Console.WriteLine("Ok.");

    do
    {
        Console.WriteLine("Do,While.");
        Console.WriteLine("What is your age?");
        age = int.Parse(Console.ReadLine());
    }
    while (age < 18);
    {
        Console.WriteLine("Ok.");
    }

    int[] numbers = { 1, 2, 3, 4, 5, 6, };

    int i = 0;

    while (i < numbers.Length)
    {
        Console.Write(numbers[i] + " ");
        i++;
    }
    Console.WriteLine("End.");
}