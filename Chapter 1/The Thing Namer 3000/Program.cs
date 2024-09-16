// See https://aka.ms/new-console-template for more information
Console.WriteLine("What kind of thing are we talking about?");
//Stores type of thing
string? a = Console.ReadLine();
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
//Details of the thing
string? b = Console.ReadLine();
string c = "of Doom";
string d = "3000";
Console.WriteLine("The " + b + " " + a + " " + c + " " + d + "!");