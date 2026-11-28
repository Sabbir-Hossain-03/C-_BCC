Random ran = new Random();
bool PlayAgain = true;
String playerChoice;
String computerChoice;
String response;

while (PlayAgain)
{
    playerChoice = "";
    computerChoice = "";
    response = "";
    while (playerChoice != "ROCK" && playerChoice != "PAPER" && playerChoice != "SCISSORS")
    {
        Console.Write("Enter your choice (Rock, Paper, Scissors): ");
        playerChoice = Console.ReadLine();
        playerChoice = playerChoice.ToUpper();
    }
    switch (ran.Next(1, 4))
    {
        case 1:
            computerChoice = "ROCK";
            break;
        case 2:
            computerChoice = "PAPER";
            break;
        case 3:
            computerChoice = "SCISSORS";
            break;
    }
    Console.WriteLine("You chose: " + playerChoice);
    Console.WriteLine("Computer chose: " + computerChoice);

    switch (playerChoice)
    {
        case "ROCK":
            if (computerChoice == "ROCK")
            {
                Console.WriteLine("It's a tie!");
            }
            else if (computerChoice == "PAPER")
            {
                Console.WriteLine("You lose!");
            }
            else
            {
                Console.WriteLine("You win!");
            }
            break;
        case "PAPER":
            if (computerChoice == "ROCK")
            {
                Console.WriteLine("You win!");
            }
            else if (computerChoice == "PAPER")
            {
                Console.WriteLine("It's a tie!");
            }
            else
            {
                Console.WriteLine("You lose!");
            }
            break;
        case "SCISSORS":
            if (computerChoice == "ROCK")
            {
                Console.WriteLine("You lose!");
            }
            else if (computerChoice == "PAPER")
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }
        break;
    }
    Console.Write("Would you want to play again? (Y/N): ");
    response = Console.ReadLine();
    response = response.ToUpper();

    if(response == "Y")
    {
        PlayAgain = true;
    }
    else
    {
        PlayAgain = false;
    }
}
Console.WriteLine("Thanks for playing!");
Console.ReadKey();
