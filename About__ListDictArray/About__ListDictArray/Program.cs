
var intList = new List<int>();

var intList2 = new List<int>() { 1, 2, 8, 7, 5, 2,};
intList2.Add(3);

int[] intArray = { 1, 2, 3 };
intList2.AddRange(intArray);

// intList2.Remove(1) first occurence.
// of if i now where, i can delete like intList2.RemoveAt(0);

intList2.Reverse();

bool contains = intList.Contains(9);

int min = intList2.Min();
int max = intList2.Max();

Console.WriteLine($"The minimum in list is : {intList2}\nThe maximum in list is :{intList2}\n");

int indexOf = intList2.IndexOf(2);
int lastOf = intList2.LastIndexOf(2);

Console.WriteLine($"The index of 2 is : {indexOf}\nThe last index of 2 is : {lastOf}\n");

for (int i = 0; i < intList2.Count; i++)
{
    Console.Write($"{intList2[i]} ");
}
Console.WriteLine();

foreach( int number in intList2)
{
    Console.Write($"{number} ");
}

var strList = new List<string>();


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