Console.Write("Enter Adjacent Side: ");
int adjacent = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Opposite Side: ");
int opposite = Convert.ToInt32(Console.ReadLine());
double hypotenuse = Math.Sqrt(Math.Pow(adjacent, 2) + Math.Pow(opposite, 2));
Console.WriteLine($"The hypotenuse of the right angled triangle is: {hypotenuse}");
Console.ReadKey();
