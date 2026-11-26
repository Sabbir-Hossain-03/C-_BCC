Console.WriteLine("What day is it? ");
String day = Console.ReadLine();
switch(day.ToLower())
{
    case "monday":
        Console.WriteLine("It's Monday!");
        break;
    case "tuesday":
        Console.WriteLine("It's Tuesday!");
        break;
    case "wednesday":
        Console.WriteLine("It's Wednesday!");
        break;
    case "thursday":
        Console.WriteLine("It's Thursday!");
        break;
    case "friday":
        Console.WriteLine("It's Friday!");
        break;
    case "saturday":
        Console.WriteLine("It's Saturday!");
        break;
    case "sunday":
        Console.WriteLine("It's Sunday!");
        break;
    default:
        Console.WriteLine("That's not a valid day.");
        break;
}
Console.ReadKey();
