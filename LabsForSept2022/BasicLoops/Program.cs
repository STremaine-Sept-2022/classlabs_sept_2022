// See https://aka.ms/new-console-template for more information

do
{
    Console.WriteLine("Hello, World!");
    Console.Write("Would you like to continue (y/n)?");
    string answer = Console.ReadLine().ToLower().Trim();
    if (answer == "n")
    {
        break;
    }

} while (true);

Console.WriteLine("Give me a integer value");
int number = int.Parse(Console.ReadLine());

for (int i = number; i >= 0; i--)
{
    Console.Write($"{i} ");
}
Console.WriteLine();
for (int i = 0; i < number; i++)
{
    Console.Write($"{i} ");
}
Console.WriteLine();

int keyCode = 0;
int entryCode = 13579;
int counter = 0;
bool isAccessGranted = false;

while (isAccessGranted == false)
{
    Console.Write("What is the key code?");
    keyCode = int.Parse(Console.ReadLine());
    counter++;
    if (keyCode == entryCode)
    {
        isAccessGranted = true;
    }
    if (counter == 5)
    {
        break;
    }
}

if (isAccessGranted)
{
    Console.WriteLine("WELCOME");
}
else
{
    Console.WriteLine("You have run out of attempts.");
}

Console.WriteLine("Press any key to exit the application.");
Console.ReadKey();

/*
// DO WHILE CODE
do
{
    Console.Write("What is the key code?");
    keyCode = int.Parse(Console.ReadLine());
    counter++;
    if (keyCode == entryCode)
    {
        isAccessGranted = true;
    }
    if (counter == 5)
    {
        break;
    }
}while (isAccessGranted == false)

// METHOD

bool IsAccessGranted(int code)
{
    while (isAccessGranted == false)
    {
        Console.Write("What is the key code?");
        keyCode = int.Parse(Console.ReadLine());
        counter++;
        if (keyCode == entryCode)
        {
            isAccessGranted = true;
        }
        if (counter == 5)
        {
            break;
        }
    }

    return isAccessGranted;
}

 */