/*
Console.Write("Enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());


//Order matters if the first if is correct the rest will not be checked.
if (age >= 100)
{
    Console.WriteLine("You are probably dead.");
}
else if (age >= 18)
{
    Console.WriteLine("You are eligible to vote.");
}
else if(age < 0)
{
    Console.WriteLine("You have not been born yet.");
}
else
{
    Console.WriteLine("You are not eligible to vote.");
}
*/

Console.Write("Enter your Name: ");
string name = Console.ReadLine();

if(name != "")
{
    Console.WriteLine("Hello, " + name);
}
else
{
    Console.WriteLine("You have not entered a name.");
}

Console.ReadKey();