// See https://aka.ms/new-console-template for more information
Console.Title = "Defense of Consolas";

Console.Write("Target Row? ");
int targetRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Target Column? ");
int targetColumn = Convert.ToInt32(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;

Console.WriteLine($"({targetRow}, {targetColumn - 1})");
Console.WriteLine($"({targetRow - 1}, {targetColumn})");
Console.WriteLine($"({targetRow}, {targetColumn + 1})");
Console.WriteLine($"({targetRow + 1}, {targetColumn})");
