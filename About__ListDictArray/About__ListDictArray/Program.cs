
Array anotherArray = Array.CreateInstance(typeof(int), new[] { 4 }, new[] { 1 });
anotherArray.SetValue(20, 1);
anotherArray.SetValue(21, 2);
anotherArray.SetValue(22, 3);
anotherArray.SetValue(23, 4);

Console.WriteLine($"Starting index : {anotherArray.GetLowerBound(0)}");
Console.WriteLine($"Ending index : {anotherArray.GetUpperBound(0)}");

for(int i = anotherArray.GetLowerBound(0); i < anotherArray.GetUpperBound(1); i++)
{
    Console.WriteLine($"{anotherArray.GetValue(i)} at index {i}");
}


static void aboutJaggedArray()
{
    int[][] jaggedArray = new int[4][];

    jaggedArray[0] = new int[1];// only 1 element
    jaggedArray[1] = new int[3];// only 3 elements
    jaggedArray[2] = new int[4];// only 4 elements
    jaggedArray[3] = new int[2];// only 2 elements

    Console.WriteLine("Enter the number for jagged array.");
    for (int i = 0; i < jaggedArray.Length; i++)
    {
        for (int j = 0; j < jaggedArray[i].Length; j++)
        {
            string st = Console.ReadLine();
            jaggedArray[i][j] = int.Parse(st);
        }
    }

    Console.WriteLine();
    Console.WriteLine("Printing elements");

    for (int i = 0; i < jaggedArray.Length; i++)
    {
        for (int j = 0; j < jaggedArray[i].Length; j++)
        {
            Console.Write(jaggedArray[i][j] + " ");
        }
        Console.WriteLine();
    }
}

static void aboutMatrix()
{
    // like matrix in math :
    int[,] r1 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
    int[,] r2 = { { 1, 2, 3 }, { 4, 5, 6 } };

    for (int i = 0; i < r2.GetLength(0); i++)
    {
        for (int j = 0; j < r2.GetLength(1); j++)
        {
            Console.Write($"{r2[i, j]} ");
        }
        Console.WriteLine();
    }
}

static void aboutStackAndQueue()
{
    //////////////////////////// Queue :
    var queue = new Queue<int>();
    queue.Enqueue(1);
    queue.Enqueue(2);
    queue.Enqueue(3);
    queue.Enqueue(4);

    Console.WriteLine($"Should print out 1: {queue.Peek()}");

    queue.Dequeue();

    Console.WriteLine($"Should print out 2: {queue.Peek()}");

    foreach (var item in queue)
    {
        Console.WriteLine(item);
    }


    //////////////////////////// Stack :
    var stack = new Stack<int>();
    stack.Push(0);
    stack.Push(1);
    stack.Push(2);
    stack.Push(3);
    stack.Push(4);

    Console.WriteLine($"Should print out 4 : {stack.Peek()}");

    stack.Pop();

    Console.WriteLine($"Should print out 3 : {stack.Peek()}");

    foreach (var i in stack)
    {
        Console.WriteLine(i);
    }
}

static void aboutDictionary()
{

    var people = new Dictionary<int, string>();

    people.Add(1, "John");
    people.Add(2, "Kile");
    people.Add(3, "Mike");

    var people_2 = new Dictionary<int, string>()
{
    {4,"Alice" },
    {5,"Marta" },
    {6,"Berta" },
};


    string name = people[1];

    Console.WriteLine(name);

    var keys = people.Keys;

    foreach (var key in keys)
    {
        Console.WriteLine($"Key : {key}");
    }

    var values = people.Values;

    foreach (var value in values)
    {
        Console.WriteLine($"Value : {value}");
    }

    foreach (var pair in people)
    {
        Console.WriteLine($"Key :{pair.Key}, Value : {pair.Value}");
    }

    Console.WriteLine($"Count : {people.Count}");

    bool containsKey = people.ContainsKey(3);
    Console.WriteLine($"Contains key : {containsKey}");

    bool cointainsValue = people.ContainsValue("Bart");
    Console.WriteLine($"Contains value : {cointainsValue}");

    // people.Remove(1);

    if (people.TryAdd(2, "Elias"))
    {
        Console.WriteLine("Added sucessfully");
    }
    else
    {
        Console.WriteLine("Can`t to add.");
    }

    if (people.TryGetValue(2, out string val))
    {
        Console.WriteLine($"Key 2, Val={val}");
    }
    else
    {
        Console.WriteLine("Failed to get.");
    }

    // people.Clear();
}

static void aboutList()
{
    var intList = new List<int>();

    var intList2 = new List<int>() { 1, 2, 8, 7, 5, 2, };
    intList2.Add(3);

    int[] intArray = { 1, 2, 3 };
    intList2.AddRange(intArray);

    // intList2.Remove(1) first occurence.
    // of if i now where, i can delete like intList2.RemoveAt(0);

    intList2.Reverse();

    bool contains = intList.Contains(9);

    int min = intList2.Min();
    int max = intList2.Max();

    Console.WriteLine($"The minimum in list is : {min}\nThe maximum in list is :{max}\n");

    int indexOf = intList2.IndexOf(2);
    int lastOf = intList2.LastIndexOf(2);

    Console.WriteLine($"The index of 2 is : {indexOf}\nThe last index of 2 is : {lastOf}\n");

    for (int i = 0; i < intList2.Count; i++)
    {
        Console.Write($"{intList2[i]} ");
    }
    Console.WriteLine();

    foreach (int number in intList2)
    {
        Console.Write($"{number} ");
    }

    var strList = new List<string>();
}

static void aboutArray() { 

    // How to create an array:
    // 3 ways.
    int[] a1 = new int[10];

    int[] a2 = new int[5] { 1, 3, -6, 7, 9 };

    int[] a3 = { 1, 5, 2, 8, 6 };

    // How program create an array:

    Array myArray = new int[5];

    Array myArray2 = Array.CreateInstance(typeof(int), 5);
    myArray2.SetValue(12, 0);

    Console.WriteLine(myArray2.GetValue(0));

    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

    int index = Array.BinarySearch(numbers, 7);// only sorted numbers.
    Console.WriteLine(index);

    int[] copy = new int[10];

    Array.Copy(numbers, copy, numbers.Length);

    int[] anotherCopy = new int[10];
    copy.CopyTo(anotherCopy, 0);

    Array.Reverse(copy);
    foreach (var i in copy)
    {
        Console.WriteLine(i);
    }

    Console.WriteLine();

    Array.Sort(copy);
    foreach (var c in copy)
    {
        Console.WriteLine(c);
    }

    Array.Clear(copy, 0, copy.Length);
};