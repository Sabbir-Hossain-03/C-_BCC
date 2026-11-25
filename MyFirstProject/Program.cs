using System.Diagnostics.SymbolStore;
/*
Console.Write("C# program."); //No new Line
Console.WriteLine("Hello, World!"); // New line
Console.WriteLine("This is my first C# program."); // New line

//This is a simple Comment in C# program.

Console.WriteLine("Sabbir\nHossain");
*/

/*
int x; //declaration
x = 12; //initialization
int y = 21; //declaration and initialization
int z = x + y; 
double height = 174.5; 
float b = 12.5f;
bool alive = true;
char symbol = '@';
String name = "Sabbir";

Console.WriteLine("The value of x is: " + x);
Console.WriteLine("The value of y is: " + y);
Console.WriteLine("The value of z is: " + z);
Console.WriteLine("The value of height is: " + height + " cm");
Console.WriteLine("The value of b is: " + b);
Console.WriteLine("Are you alive?: " + alive);
Console.WriteLine("The value of symbol is: " + symbol);
Console.WriteLine("Hello, " + name);

String UserName = symbol + name;
Console.WriteLine("The UserName is: " + UserName);
*/

/*
//Constants
const double pi = 3.1416;
Console.WriteLine(pi);
*/

/*
//typecasting
double a = 3.14;
int b = Convert.ToInt32(a);
Console.WriteLine(a.GetType());
Console.WriteLine(b.GetType());

int c = 123;
double d = Convert.ToDouble(c) + 0.1;
Console.WriteLine(d);
Console.WriteLine(d.GetType());

int e = 321;
String f = Convert.ToString(e);
Console.WriteLine(f);
Console.WriteLine(f.GetType());

String g = "$";
char h = Convert.ToChar(g);
Console.WriteLine(h);
Console.WriteLine(h.GetType());

String i = "true";
bool j = Convert.ToBoolean(i);
Console.WriteLine(j);
Console.WriteLine(j.GetType());
*/

/*
//User Input
Console.WriteLine("Enter your name: ");
String name = Console.ReadLine();
Console.WriteLine("Hello, " + name);

Console.WriteLine("Enter your age: ");
int age = Convert.ToInt32(Console.ReadLine()); // Need to convert the input because the input is a string by default.
Console.WriteLine("You are " + age + " years old.");
*/

/*
//basic arithmetic

int friends = 10;
//friends = friends + 1;
//friends += 2;
//friends++;
//friends = friends - 1;
//friends -= 2;
//friends--;
//friends = friends * 2;
//friends *= 2;
//friends = friends / 2;
//friends /= 2;

int remainder = friends % 2;

Console.WriteLine(friends);
Console.WriteLine(remainder);
*/

//Math class
double x = 40.86;
double y = 5;
//double y = Math.Pow(x, 2);
//double y = Math.Sqrt(x);
//double y = Math.Round(x);
//double y = Math.Ceiling(x);
//double y = Math.Floor(x);
//double g = Math.Max(x, y);
double g = Math.Min(x, y);

Console.WriteLine(g);


Console.ReadKey();