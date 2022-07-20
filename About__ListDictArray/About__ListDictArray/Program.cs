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
foreach(var i in copy)
{
    Console.WriteLine(i);
}

Console.WriteLine();

Array.Sort(copy);
foreach(var c in copy)
{
    Console.WriteLine(c);
}

Array.Clear(copy, 0, copy.Length);