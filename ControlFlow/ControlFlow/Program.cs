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

static void breakContinue()
{
    int[] nmbs = { 0, 2, 4, 7, 5, 3, 6, 1, 8, 9 };

    for (int i = 0; i < nmbs.Length; i++)
    {
        if (nmbs[i] % 2 != 0)
        {
            continue;
        }
        Console.WriteLine(nmbs[i]);
    }


    int[] numbrs = { 0, 2, 4, 7, 5, 3, 6, 1, 8, 9 };
    char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };

    for (int i = 0; i < numbrs.Length; i++)
    {
        Console.WriteLine($"Number : {numbrs[i]}" + " ");
        for (int j = 0; j < letters.Length; j++)
        {
            if (numbrs[i] == j)
            {
                break;
            }
            Console.Write($"{letters[j]} ");

        }
        Console.WriteLine();
    }


    int[] numbers = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };

    int count = 0;

    for (int i = 0; i < numbers.Length - 1; i++)
    {
        if (count == 3)
        {
            break;
        }
        for (int j = i + 1; j < numbers.Length; j++)
        {
            int aI = numbers[i];
            int bJ = numbers[j];

            if (aI + bJ == 0)
            {
                Console.WriteLine($"Pairs ({aI};{bJ}). Indexes ({i};{j})");
                count++;
            }
            if (count == 3)
            {
                break;
            }
        }
    }
}

static void switchMethod()
{
    int month = int.Parse(Console.ReadLine());

    string season = string.Empty;

    switch (month)
    {
        case 1:
        case 2:
        case 12:
            season = "Winter";
            break;
        case 3:
        case 4:
        case 5:
            season = "Spring";
            break;
        case 6:
        case 7:
        case 8:
            season = "Summer";
            break;
        case 9:
        case 10:
        case 11:
            season = "Autumn";
            break;
        default:
            season = "Unexpected number of month.";
            break;
    }
    Console.WriteLine(season);


    int weddingYears = int.Parse(Console.ReadLine());

    string name = string.Empty;

    switch (weddingYears)
    {
        case 5:
            name = "Wood wedding.";
            break;
        case 10:
            name = "Stannic wedding.";
            break;
        case 15:
            name = "Crystal wedding.";
            break;
        case 20:
            name = "Porcelain wedding.";
            break;
        case 25:
            name = "Silver wedding.";
            break;
        case 30:
            name = "Pearl wedding.";
            break;
        default:
            name = "We don`t know this jubilee.";
            break;
    }
    Console.WriteLine(name);
}

// Second Task :
// Fibonacci number`s. The user must to enter a count of numbers which will be generated.

static void Fibonacci()
{
    Console.WriteLine("Enter a numbers of Fibonacci");

    int number = int.Parse(Console.ReadLine());

    var myList = new List<int> { 1, 1 };

    for (int i = 0; i < number; i++)
    {
        int number_1 = myList[i];
        int number_2 = myList[myList.Count() - 1];
        int sum = number_1 + number_2;
        myList.Add(sum);
    }

    foreach (int i in myList)
    {
        Console.WriteLine(i);
    }
}

// Third Task:
// The user write 10 numebrs >0 and stop when he will have all 10 numbers or when the user write a 0.
// After than must to find out a Arithmetic mean and all numbers divided by 3.

static void FindAndCount()
{

    Console.WriteLine("Enter 10 positive numbers:");
    int i = 0;

    var myList = new List<int> { };

    var myListToThree = new List<int> { };

    while (i < 10)
    {
        int number = int.Parse(Console.ReadLine());
        if (number > 0)
        {
            myList.Add(number);
            i++;
        }
        else if (number == 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("The numbers must to be positive.");
        }
    }

    int findMiddle = myList.Sum() / myList.Count();

    for (int j = 0; j < myList.Count(); j++)
    {
        if (j % 3 == 0)
        {
            myListToThree.Add(j);
        }
    }

    Console.WriteLine($"The Arithmetic mean is:{findMiddle}");
    Console.WriteLine("All numbers which is divided by 3:");
    foreach (int number in myListToThree)
    {
        Console.Write($"{number}" + ",");
    }
}

// Fourth Task:
// Find a Factorial of number.

static void FindFactorial()
{

    Console.WriteLine("Write a number to find out a Factorial:");

    int number = int.Parse(Console.ReadLine());

    var listOfNumbers = new List<int>() { };

    int result = 1;

    for (int i = 1; i <= number; i++)
    {
        listOfNumbers.Add(i);
    }

    foreach (int j in listOfNumbers)
    {
        result *= j;
    }

    Console.WriteLine(result);
}

// Five Task:
// Make a authentification like user have login - skywalker and password - qwerty
// If user write incorrect  three times finish a programm 
// If the user have correct login the system must to write "Enter the system"
// The number of available tries have been exceeded

Dictionary<string, string> Users = new Dictionary<string, string>() { {"login","skywalker" },
                                                                     {"password","qwerty" }, };

Console.WriteLine("To enter to the system write your login and password. Correct , you have only 3 tries.");
int count = 1;

while(true)
{
    Console.WriteLine("Write here you login:");
    string login = Console.ReadLine();
    if(Users.ContainsValue(login))
    {
        while (true)
        {
            Console.WriteLine("Write here your password:");
            string password = Console.ReadLine();
            if (Users.ContainsValue(password))
            {
                Console.WriteLine("Enter in to the system.");
                break;
            }
            else if (count == 3)
            {
                break;
            }
            else
            {
                count++;
            }
        }
    }
    else if (count == 3)
    {
        Console.WriteLine("The number of available tries have been exceeded");
        break;
    }
    else
    {
        Console.WriteLine("Write please correct login.");
    }
}