using System;
using System.IO;
using System.Text;

static void aboutExceptions()
{
    Console.WriteLine("Write a number");

    string result = Console.ReadLine();

    int number = 0;
    try
    {
        number = int.Parse(result);
    }
    catch (FormatException ex)
    {
        Console.WriteLine("The program was fall");
        Console.WriteLine("The information about fall below. ");
        Console.WriteLine(ex.ToString());
    }
    //finally { write it in the end.}
    Console.WriteLine(number);
}


static void aboutWorkWithFiles()
{
    string[] allLines = File.ReadAllLines("test.txt");
    string alltext = File.ReadAllText("test.txt");
    Console.WriteLine("Use a all lines");
    Console.WriteLine(allLines);
    Console.WriteLine("Use all text:");
    Console.WriteLine(alltext);

    //IEnumerable<string> lines = File.ReadLines("test.txt"); // most usefull when i have a lot of files.

    File.WriteAllText("Test_2.txt", "It`s a second text file..");
    File.WriteAllLines("test_3.txt", new string[] { "My name", "is ?" });

    Stream fs = new FileStream("test.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
    try
    {
        string str = "Hello new string.";
        byte[] strInBytes = Encoding.ASCII.GetBytes(str);

        fs.Write(strInBytes, 0, strInBytes.Length);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.ToString()}");
    }
    finally
    {
        fs.Close();
    }
    // using it`s like try-finally...
    using (Stream readingStream = new FileStream("test.txt", FileMode.Open, FileAccess.Read))
    {
        byte[] temp = new byte[readingStream.Length];

        int bytesToRead = (int)readingStream.Length;
        int bytesRead = 0;
        // int len = 0; 
        while (bytesToRead > 0)
        //(len = readingStream.Read(temp, 0, temp.Length)) > 0)
        {
            int n = readingStream.Read(temp, bytesRead, bytesToRead);
            //string str = Encoding.ASCII.GetString(temp, 0, len);
            if (n == 0)
            {
                break;
            }
            bytesRead += n;
            bytesToRead -= n;
        }
        string str = Encoding.ASCII.GetString(temp, 0, temp.Length);
        Console.WriteLine(str);
    };
};

File.Copy("test.txt","test_copy.txt",overwrite:true);

//File.Move("test_copy.txt", "test_renamed.txt");
File.Delete("test_copy.txt");