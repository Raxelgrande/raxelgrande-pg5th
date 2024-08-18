// See https://aka.ms/new-console-template for more information
int roundNumber = 0;
int manticoreHealth = 10;
int cityHealth = 16; //15, gets one less on game start
bool gameStatus = false;
// Player 1 Color = Red
// Player 2 color = Blue
// Round failure highlight = Yellow
// Round hit highlight = Green


Console.Clear();

while (gameStatus == false) RoundStatus();

void RoundStatus() 
{ 
    int manticoreDistance = SetManticore();
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Player 2, it is your turn.");
    cityHealth--;
    roundNumber++;
    Console.WriteLine("-----------------------------------------------------------");
    Console.WriteLine($"STATUS: Round: {roundNumber} City: {cityHealth}/15 Manticore: {manticoreHealth}/10");
    int possibleDamage = CannonStatus();
    int hitStatus = SetCannon(manticoreDistance, possibleDamage); 
    if (hitStatus == 0)
    {
        manticoreHealth -= possibleDamage;
    }
    else if (hitStatus == 1)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("That round OVERSHOT the target");
        Console.ForegroundColor = ConsoleColor.White;
    }
    else if (hitStatus == 2)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("That round FELL SHORT of the target");
        Console.ForegroundColor = ConsoleColor.White;
    }
    Console.WriteLine("-----------------------------------------------------------");
    
    if (manticoreHealth <= 0 || manticoreHealth == 0) 
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Congratulations Player 2! The Manticore has been destroyed! The city of Consolas has been saved!");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Thanks for playing!");
        gameStatus = true;
    }
    else if (cityHealth <= 0 || cityHealth == 0)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Congratulations Player 1! The city has been destroyed!");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Thanks for playing!");
        gameStatus = true;
    }
}

int SetManticore() 
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Player 1, how far away from the city do you want to station the Manticore?");
    int manticoreDistance = Convert.ToInt32(Console.ReadLine());
    if (manticoreDistance > 100) 
    {
        Console.WriteLine("The number is too big!");
        SetManticore();
        return 0;
    }
    else if (manticoreDistance < 0) 
    {
        Console.WriteLine("The number is too small!");
        SetManticore();
        return 0;
    }
    else
    {
        Console.Clear();
        return manticoreDistance;
    }
}

int CannonStatus() 
{
    if (roundNumber % 5 == 0 && roundNumber % 3 == 0)
    {
        Console.WriteLine("The cannon is expected to deal 10 points of damage");
        return 10;
    }
    else if (roundNumber % 3 == 0 || roundNumber % 5 == 0) 
    {
        Console.WriteLine("The cannon is expected to deal 3 points of damage");
        return 3;
    }
    else 
    {
        Console.WriteLine("The cannon is expected to deal 1 point of damage");
        return 1;
    } 
}

int SetCannon(int manticoreLocation, int cannonDamage)
{
    Console.Write("\nEnter desired cannon range: ");
    int cannonDistance = Convert.ToInt32(Console.ReadLine());
    
    if (cannonDistance == manticoreLocation)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("That round was a DIRECT HIT!");
        Console.ForegroundColor = ConsoleColor.White;
        int manticoreHealth = cannonDamage;
        return 0;
    }
    
    else if (cannonDistance >= 100 || Enumerable.Range(manticoreLocation,100).Contains(cannonDistance)) return 1;
    
    else if (cannonDistance <= 0 || Enumerable.Range(0,manticoreLocation).Contains(cannonDistance)) return 2;
    
   
    else return 3;
}