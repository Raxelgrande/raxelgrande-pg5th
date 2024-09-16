// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please give a value to the X coordinate");
string? xVal = Console.ReadLine();
int xValInt = Convert.ToInt32(xVal);

Console.WriteLine("Please give a value to the Y coordinate");
string? yVal = Console.ReadLine();
int yValInt = Convert.ToInt32(yVal);

if (xValInt < 0 && yValInt > 0) 
{
    Console.WriteLine("The enemy approaches form the Northwest");
}
else if (xValInt == 0 && yValInt > 0) 
{
    Console.WriteLine("The enemy approaches form the North");
}
else if (xValInt > 0 && yValInt > 0) 
{
    Console.WriteLine("The enemy approaches form the Northeast");
}
else if (xValInt < 0 && yValInt == 0)
{
    Console.WriteLine("The enemy approaches form the West");
}
else if (xValInt == 0 && yValInt == 0)
{
    Console.WriteLine("The enemy is here!");
}
else if (xValInt > 0 && yValInt == 0)
{
    Console.WriteLine("The enemy approaches form the East");
}
else if (xValInt < 0 && yValInt < 0)
{
    Console.WriteLine("The enemy approaches form the Southwest");
}
else if (xValInt == 0 && yValInt < 0)
{
    Console.WriteLine("The enemy approaches from the South");
}
else if (xValInt > 0 && yValInt < 0)
{
    Console.WriteLine("The enemy approaches form the Southeast");
}