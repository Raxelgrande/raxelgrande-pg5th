// See https://aka.ms/new-console-template for more information
int user1Value;
do 
{
    Console.Write("User 1, enter a number between 0 and 100: ");
    user1Value = Convert.ToInt32(Console.ReadLine());
}
while (user1Value < 0 || user1Value > 100);

Console.Clear();

Console.WriteLine("User 2, guess the number. ");

while(true)
{
    Console.Write("What is your next guess? ");
    int guess = Convert.ToInt32(Console.ReadLine());

    if (guess > user1Value) Console.WriteLine($"{guess} is too high.");
    else if (guess < user1Value) Console.WriteLine($"{guess} is too low.");
    else break;
}

Console.WriteLine("You guessed the number!");