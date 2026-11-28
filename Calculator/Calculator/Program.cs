using System.Threading.Channels;
do {
    double num1 = 0;
    double num2 = 0;
    double result = 0;

    Console.WriteLine("------------------");
    Console.WriteLine("Calculator Program");
    Console.WriteLine("------------------");

    Console.Write("Enter the first number: ");
    num1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter the second number: ");
    num2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter an option: ");
    Console.WriteLine("\t+ : Add");
    Console.WriteLine("\t- : Subtract");
    Console.WriteLine("\t* : Multiply");
    Console.WriteLine("\t/ : Divide");
    Console.Write("Enter your choice: ");

    switch (Console.ReadLine())
    {
        case "+":
            result = num1 + num2;
            Console.WriteLine($"Your result: {num1} + {num2} = " + result);
            break;
        case "-":
            result = num1 - num2;
            Console.WriteLine($"Your result: {num1} - {num2} = " + result);
            break;
        case "*":
            result = num1 * num2;
            Console.WriteLine($"Your result: {num1} * {num2} = " + result);
            break;
        case "/":
            while (num2 == 0)
            {
                Console.WriteLine("Enter a non-zero divisor: ");
                num2 = Convert.ToDouble(Console.ReadLine());
            }
            result = num1 / num2;
            Console.WriteLine($"Your result: {num1} / {num2} = " + result);
            break;
        default:
            Console.WriteLine("Invalid option");
            break;
    }
    Console.WriteLine("Would you like to perform another calculation? (y/n)");
} 
while (Console.ReadLine().ToUpper() == "Y");
Console.WriteLine("Thank you for using the calculator!");
Console.ReadKey();