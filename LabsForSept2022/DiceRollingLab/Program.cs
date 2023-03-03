

while(true)
{
    Console.WriteLine("How many sides do your dice have?");
    int diceSideCount = int.Parse(Console.ReadLine());
    Console.WriteLine("Press any key to roll the dice.");
    Console.ReadKey();

    int firstRoll = GenerateRandomNumber(diceSideCount);
    int secondRoll = GenerateRandomNumber(diceSideCount);
    Console.WriteLine($"You rolled a {firstRoll + secondRoll}");

    // Terminate here if not 6 sided die
    if (diceSideCount != 6)
    {
        Console.WriteLine("Unfortunately this game only works with 6 sided dice. ");
        if (ContinuePlay())
        {
            continue;
        }
        else
        {
            break;
        }
    }

    Console.WriteLine(RespondToD6Roll(firstRoll,secondRoll));
    Console.WriteLine(DetermineWinCondition(firstRoll, secondRoll));
    if (ContinuePlay())
    {
        continue;
    }
    else
    {
        break;
    }
}

Console.WriteLine("Press any key to exit the program.");
Console.ReadKey();

static bool ContinuePlay()
{
    Console.WriteLine("Would you like to play again? Anything but YES will end the game.");
    return Console.ReadLine() == "YES";
}

static int GenerateRandomNumber(int diceSideCount)
{
    Random random = new Random();
    return random.Next(1,diceSideCount+1);
}

static string RespondToD6Roll(int firstValue, int secondValue)
{
    int sum = firstValue + secondValue;
    switch (sum)
    {
        case 2:
            return "Snake Eyes";
        case 3:
            return "Ace Deuce";
        case 12:
            return "Box Cars";
        default:
            return "";
    }
}

static string DetermineWinCondition(int firstValue, int secondValue)
{
    int sum = firstValue + secondValue;
    switch (sum)
    {
        case 7:
        case 11:
            return "You Win";
        case 2:
        case 3:
        case 12:
            return "Craps";
        default:
            return "";
    }
}