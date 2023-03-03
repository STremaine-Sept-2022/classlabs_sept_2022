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

}while (true);

