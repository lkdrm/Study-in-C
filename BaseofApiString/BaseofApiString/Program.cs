using System.Text;



static void basedofStr()
{
    string name = "Alukardan";

    bool containA = name.Contains("a");
    bool containB = name.Contains("b");

    bool endsWitha = name.EndsWith("ard");
    Console.WriteLine(endsWitha);

    bool startsWitha = name.StartsWith("Al");
    Console.WriteLine(startsWitha);

    int indexofA = name.IndexOf("a");
    Console.WriteLine(indexofA);

    int lastIndexofA = name.LastIndexOf("a");
    Console.WriteLine(lastIndexofA);

    Console.WriteLine($"The len of name is {name.Length}");

    string subStringFrom5 = name.Substring(5);
    string subStringFromTo = name.Substring(0, 3);
    Console.WriteLine(subStringFrom5);
    Console.WriteLine(subStringFromTo);
}

static void StringOrEmptyorNullSpace()
{
    string empty = "";
    string whiteSpaced = " ";
    string notEmpty = " b";
    string nullString = null;
    Console.WriteLine(nullString);

    Console.WriteLine("Is null or empty.");

    bool isNullorEmpty = string.IsNullOrEmpty(nullString);
    Console.WriteLine(isNullorEmpty);

    isNullorEmpty = string.IsNullOrEmpty(whiteSpaced);
    Console.WriteLine(isNullorEmpty);

    isNullorEmpty = string.IsNullOrEmpty(notEmpty);
    Console.WriteLine(isNullorEmpty);

    isNullorEmpty = string.IsNullOrEmpty(empty);
    Console.WriteLine(isNullorEmpty);
    /////////////////////////
    Console.WriteLine("Is null or whitespace.");

    bool isNullorWhiteSpaced = string.IsNullOrWhiteSpace(empty);
    Console.WriteLine($"Empty string : {isNullorWhiteSpaced}");

    isNullorWhiteSpaced = string.IsNullOrWhiteSpace(whiteSpaced);
    Console.WriteLine($"whiteSpaced : {isNullorWhiteSpaced}");

    isNullorWhiteSpaced = string.IsNullOrWhiteSpace(notEmpty);
    Console.WriteLine($"notEmpty : {isNullorWhiteSpaced}");

    isNullorWhiteSpaced = string.IsNullOrWhiteSpace(nullString);
    Console.WriteLine($"nullString : {isNullorWhiteSpaced}");
}

static void methodsOfStrings()
{

    string nameConcat = string.Concat("My ", "name ", "is ", "John.");
    Console.WriteLine(nameConcat);

    nameConcat = string.Join("-", "My", "name", "is", "John.");
    Console.WriteLine($"With method join : {nameConcat}");

    nameConcat = "My " + "name " + "is " + "John.";

    //string newName =
    nameConcat = nameConcat.Insert(0, "By the way - ");
    Console.WriteLine(nameConcat);

    //nameConcat = nameConcat.Remove(0);// if 0 delete all string.

    string replaced = nameConcat.Replace('n', 'z');
    Console.WriteLine($"Method replaced : {replaced}");

    string data = "12;28;34;25;64";

    string[] spliData = data.Split(";");
    string first = spliData[0];
    Console.WriteLine(spliData);
    Console.WriteLine(first);

    char[] chars = nameConcat.ToCharArray();
    Console.WriteLine(chars[0]);
    Console.WriteLine(nameConcat[0]);

    string lower = nameConcat.ToLower();
    Console.WriteLine($"To lower : {lower}");

    string upper = nameConcat.ToUpper();
    Console.WriteLine($"To upper : {upper}");

    string newStr = " My name is John ";
    Console.WriteLine(newStr.Trim());
}

static void StrBuilder()
{
    StringBuilder sb = new StringBuilder();
    sb.Append("My ");
    sb.Append("name ");
    sb.Append("is ");
    sb.Append("John.");
    sb.AppendLine("!");
    sb.AppendLine("Hello!");


    string str = sb.ToString();
    Console.WriteLine(str);
}

static void FormatStr()
{

    string name = "John";
    int age = 26;

    string str1 = string.Format("My name is {0} & I`m {1}.", name, age);
    //or
    string str2 = "My name is " + name + " and I`m " + age;
    //or
    string str3 = $"My name is {name} & I`m {age}.";

    Console.WriteLine(str1);
    Console.WriteLine(str3);

    string str4 = "My name is \nJohn.";
    Console.WriteLine(str4);

    string str5 = "I`m \t 26.";
    Console.WriteLine(str5);

    string str6 = $"My name is {Environment.NewLine}John.";
    Console.WriteLine(str6);

    string str7 = "I`m a John & i`m a 'good' programmer.";
    Console.WriteLine(str7);

    string str8 = "C:\\tmp\\test_file.txt";
    //or
    string str9 = @"C:\tmp\test_file.txt";
    Console.WriteLine(str8);
    Console.WriteLine(str9);


    int answer = 42;
    string result = string.Format("{0:d}", answer);
    string result2 = string.Format("{0:d4}", answer);
    Console.WriteLine(result);
    Console.WriteLine(result2);

    result = string.Format("{0:f}", answer);
    result2 = string.Format("{0:f4}", answer);
    Console.WriteLine(result);
    Console.WriteLine(result2);

    Console.OutputEncoding = Encoding.UTF8;

    double money = 12.8;

    result = string.Format("{0:C}", money);
    result2 = string.Format("{0:C2}", money);
    Console.WriteLine(result);
    Console.WriteLine(result2);
    //or
    Console.WriteLine(money.ToString("C2"));

    Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

    Console.WriteLine(money.ToString("C2"));
}

static void equalStrings()
{

    string str1 = "abcde";
    string str2 = "abcde";

    bool areEqual = str1 == str2;
    Console.WriteLine(areEqual);

    areEqual = string.Equals(str1, str2, StringComparison.Ordinal);
    Console.WriteLine(areEqual);

    string s1 = "Strasse";
    string s2 = "Straße";

    areEqual = string.Equals(s1, s2, StringComparison.Ordinal);// most usefull
    Console.WriteLine(s1);
    Console.WriteLine(areEqual);

    areEqual = string.Equals(s1, s2, StringComparison.InvariantCulture);
    Console.WriteLine(areEqual);

    areEqual = string.Equals(s1, s2, StringComparison.CurrentCulture);
    Console.WriteLine(areEqual);
}

static void inputString()
{
    //Console.WriteLine("Hi, please tell me your name: ");

    //string name = Console.ReadLine();
    //string sentence = $"Your name is {name}";
    //Console.WriteLine(sentence);

    Console.WriteLine("Hi, please tell me your age: ");
    string input = Console.ReadLine();
    int age = int.Parse(input);

    string sentence = $"Your age is {age}";
    Console.WriteLine(sentence);

    Console.Clear();
    Console.BackgroundColor = ConsoleColor.Cyan;
    Console.ForegroundColor = ConsoleColor.Magenta;

    Console.Write("New style ");
    Console.Write("New style\n");
}

static void parsing()
{
    byte b = 3; // 0000 0011
    int i = b; // 0000 0000 0000 0000 0000 0000 0000 0011
    long l = i; // 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0011
    Console.WriteLine(b);

    float f = i; // 3.0

    b = (byte)i;
    Console.WriteLine(b);

    i = (int)f;
    Console.WriteLine(i);

    string str = "1";
    // i = (int)str;

    i = int.Parse(str);
    Console.WriteLine($"Parsed i = {i}");

    int x = 5;
    int result = x / 2;
    Console.WriteLine(result);

    double result2 = (double)x / 2;
    Console.WriteLine(result2);
}

static void comments()
{
    // a single-line comment

    /*
     * Multi-line comment
     * We can write here many words
     * 
     */

    // describe how is and why is.
}

static void moduleMath()
{

    Console.WriteLine(Math.Pow(2, 3));
    Console.WriteLine(Math.Sqrt(9));
    Console.WriteLine(Math.Sqrt(8));
    Console.WriteLine(Math.Round(1.7));
    Console.WriteLine(Math.Round(1.4));
    Console.WriteLine($"Just round : {Math.Round(2.5)}");
    Console.WriteLine($"Round with away from zero : {Math.Round(2.5, MidpointRounding.AwayFromZero)}");
    Console.WriteLine($"Round to even {Math.Round(2.5, MidpointRounding.ToEven)}");
}

static void somethingAboutMassive()
{
    int[] a1; // created a masive type int
    a1 = new int[10]; // only two elements

    int[] a2 = new int[5];

    int[] a3 = new int[5] { 1, 2, -3, 5, 10 };

    int[] a4 = { 1, 3, 2, 4, 5 };

    Console.WriteLine(a4[2]);

    a4[4] = 6;
    Console.WriteLine(a4[4]);
    Console.WriteLine(a4.Length);
    Console.WriteLine(a4[a4.Length - 1]); // find a last index in massive

    string s1 = "abcdef";
    char first = s1[0];
    char last = s1[s1.Length - 1];
    Console.WriteLine($"The first index of str is : {first}");
    Console.WriteLine($"The last index of str is : {last}");
    Console.WriteLine($"The length of str is : {s1.Length}");
}

static void aboutDatetime()
{
    DateTime now = DateTime.Now;
    Console.WriteLine(now.ToString());

    Console.WriteLine($"It`s {now.Date}");

    DateTime dt = new DateTime(2016, 2, 28);
    DateTime newDt = dt.AddDays(1);
    Console.WriteLine(newDt);

    TimeSpan ts = now - dt;
    //ts = now.Subtract(dt);

    Console.WriteLine(ts.TotalDays);
}