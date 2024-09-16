// See https://aka.ms/new-console-template for more information
Recursical(10);

void Recursical(int number)
{
    if (number == 0) return;
    Console.WriteLine(number);
    Recursical(number - 1);
}