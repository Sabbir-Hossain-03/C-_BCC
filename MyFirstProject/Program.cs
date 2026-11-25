using System.Diagnostics.SymbolStore;

Console.Write("C# program."); //No new Line
Console.WriteLine("Hello, World!"); // New line
Console.WriteLine("This is my first C# program."); // New line

/*
 This is a simple Comment in C# program.
*/
Console.WriteLine("Sabbir\nHossain");



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



Console.ReadKey();