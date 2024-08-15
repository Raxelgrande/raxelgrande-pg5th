// See https://aka.ms/new-console-template for more information
for (int x = 1; x <= 100; x++)
{
    if (x % 5 == 0 && x % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(x + ": Combined Fire and Electric");
        Console.ForegroundColor = ConsoleColor.White;
    }
    if (x % 3 == 0) 
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(x + ": Fire");
        Console.ForegroundColor = ConsoleColor.White;
    }
    else if (x % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(x + ": Electric");
        Console.ForegroundColor = ConsoleColor.White;
    }
    else 
    {
        Console.WriteLine(x + ": Normal");
    }
}