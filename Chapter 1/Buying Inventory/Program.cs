// See https://aka.ms/new-console-template for more information
Console.WriteLine("The following items are available:\n1 – Rope\n2 – Torches\n3 – Climbing Equipment\n4 – Clean Water\n5 – Machete\n6 – Canoe\n7 – Food Supplies");
Console.WriteLine("What product do you want to see the price of?");

int itemBuy = Convert.ToInt32(Console.ReadLine());

switch (itemBuy)
{
    case 1:
        Console.WriteLine("Rope costs 10 gold");
        break;
    case 2:
        Console.WriteLine("Torches cost 15 gold");
        break;
    case 3: 
        Console.WriteLine("The Climbing Equipment costs 25 gold");
        break;
    case 4:
        Console.WriteLine("Clean Water costs 1 gold");
        break;
    case 5:
        Console.WriteLine("The Machete costs 20 gold");
        break;
    case 6: 
        Console.WriteLine("The Canoe costs 200 gold");
        break;
    case 7: 
        Console.WriteLine("The Food Supplies cost 1 gold");
        break;
    default:
        Console.WriteLine("I didn't understand what you asked me for...");
        break;
}