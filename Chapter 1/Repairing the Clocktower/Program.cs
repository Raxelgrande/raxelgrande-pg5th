// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input a number");
string? input = Console.ReadLine();
int inputInt = Convert.ToInt32(input);
if (inputInt % 2 == 0)
{
    Console.WriteLine("Tick");
}
else 
{
    Console.WriteLine("Tock");
}