internal class Program
{
    private static void Main(string[] args)
    {
        static void DisplayFilesWithOutLinq(string pathToDir)
        {
            var dirInf = new DirectoryInfo(pathToDir);
            FileInfo[] files = dirInf.GetFiles();

            Array.Sort(files, FilesComparisson);

            for (int i = 0; i < 5; i++)
            {
                FileInfo file = files[i];
                Console.WriteLine($"{file.Name} has {file.Length}");
            }
        }

        static int FilesComparisson(FileInfo x, FileInfo y)
        {
            if (x.Length == y.Length) return 0;
            if (x.Length > y.Length) return -1;
            return 1;
        }

        DisplayFilesWithOutLinq(@"D:\Програми");
        Console.ReadLine();

        static void DisplayFilesWithLinq(string pathToDir)
        {
            new DirectoryInfo(pathToDir).GetFiles().OrderByDescending(file => file.Length).Take(5);
        }

        DisplayFilesWithLinq(@"D:\Програми");
    }
}

//static long KeySelector(FileInfo file)
//{
//    return file.Length;
//}

static class LinqExtensions
{
    public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
    {
        if (source == null)
        {
            throw new ArgumentNullException();
        }
        foreach(var item in source)
        {
            action(item);
        }
    }
}
class Prg
{
    static void DisplayFilesWithLinq(string pathToDir)
    {
        new DirectoryInfo(pathToDir).GetFiles().OrderByDescending(file => file.Length).Take(5).ForEach(file => Console.WriteLine($"{file.Name} has {file.Length}"));
    }
}

