Console.Write("Enter the name of today: ");
String day = Console.ReadLine();
switch(day.ToLower())
{
    case "saturday":
        Console.Write("Today is : " + day);
        break;
    case "sunday":
        Console.Write("Today is : " + day);
        break;
    case "monday":
        Console.Write("Today is : " + day);
        break;
    case "tuesday":
        Console.Write("Today is : " + day);
        break;
    case "wednesday":
        Console.Write("Today is : " + day);
        break;
    case "thursday":
        Console.Write("Today is : " + day);
        break;
    case "friday":
        Console.Write("Today is : " + day);
        break;
    default:
        Console.Write(day + " is not a valid day!");
        break;
}
Console.ReadKey();
