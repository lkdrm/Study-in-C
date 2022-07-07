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
result2 = string.Format("{0:f4}",answer);
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