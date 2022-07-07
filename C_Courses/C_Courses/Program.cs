int x = -1;
int y =  2;
y = 3;

// uint z = -1  uint can`t be less as zero 0<-1;
float f = 1.1f; // this is float in the end i must write a f.
double d = 2.3;

int x2 = 0;
int x3 = new int();

var a = 1;
var dict = new Dictionary<int, string>();

decimal money = 3.0m;
char character = 'A';
string name = "John";
/////////////////////////////////
bool canDrive = true;

object obj1 = 1;

Console.WriteLine(x);
Console.WriteLine(a);
Console.WriteLine(name);

int c = 0b11;
int b = 0b1001;
Console.WriteLine(d);
Console.WriteLine(c);

var fb = 4.5e2;
var bd = 3.1E-1;
Console.WriteLine(fb);
Console.WriteLine(bd);


checked
{
    uint z = uint.MaxValue;
    Console.WriteLine(z);
    z = z + 1;
    Console.WriteLine(z);
}
////////////////
///
