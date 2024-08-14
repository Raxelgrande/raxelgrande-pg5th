// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please, insert the number of chocolate eggs gathered today");
string? getEgg = Console.ReadLine();
int eggNumber = Convert.ToInt32(getEgg);

decimal eggRemainder = eggNumber % 4;
decimal eggAmount = eggNumber / 4;

Console.WriteLine("In the case the number of eggs are equal, each sister should get: " + eggAmount);
Console.WriteLine("Otherwise, there would remain: " + eggRemainder);