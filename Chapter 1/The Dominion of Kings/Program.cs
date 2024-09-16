// See https://aka.ms/new-console-template for more information
Console.WriteLine("How many Provinces do you have?");
string? provinceUser = Console.ReadLine();
int provinceUserInt = Convert.ToInt32(provinceUser);

Console.WriteLine("How many Duchies do you have?");
string? duchieUser = Console.ReadLine();
int duchieUserInt = Convert.ToInt32(duchieUser);

Console.WriteLine("How many Estates do you have?");
string? estateUser = Console.ReadLine();
int estateUserInt = Convert.ToInt32(estateUser);

int estateMultiplier = 1;
int duchieMultiplier = 3;
int provinceMultiplier = 6;

int provinceResult = provinceUserInt * provinceMultiplier;
int duchieResult = duchieUserInt * duchieMultiplier;
int estateResult = estateUserInt * estateMultiplier;

Console.WriteLine("Your amount of Provinces are equal to: " + provinceResult + " points");
Console.WriteLine("Your amount of Duchies are equal to: " + duchieResult + " points");
Console.WriteLine("Your amount of Estates are equal to: " + estateResult + " points");

Console.WriteLine("Your point total is: " + (provinceResult + duchieResult + estateResult));