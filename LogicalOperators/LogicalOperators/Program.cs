Console.Write("Whats the temparature outsite(°C): ");
double temp = Convert.ToDouble(Console.ReadLine());
if(temp >= 10 && temp <= 25)
{
    Console.WriteLine("It's warm outside");
}
else if(temp <= -50 || temp >= 50)
{
    Console.WriteLine("Don't go outside");
}
Console.ReadKey();
