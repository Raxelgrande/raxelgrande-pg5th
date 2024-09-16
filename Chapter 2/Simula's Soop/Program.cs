// See https://aka.ms/new-console-template for more information
Console.WriteLine($"Your soup is: {Seasoning()} {Food()} {Ingredient()}");

string Seasoning() 
{
    Console.WriteLine("What kind of Seasoning would you like?\nValid options are: Spicy, Salty and Sweet");
    string? pickSeasoning = Console.ReadLine().ToString();
    
    if (pickSeasoning == "Spicy" || pickSeasoning == "Salty" || pickSeasoning == "Sweet")  return pickSeasoning;

    else if (pickSeasoning != "Spicy" || pickSeasoning != "Salty" || pickSeasoning != "Sweet")
    {
        Console.WriteLine("shit");
        Seasoning();
        return "";
    }
    else return "";
}

string Food()
{
    Console.WriteLine("What kind of Food would you like to eat?\nValid options are: Soup, Stew and Gumbo");
    string? pickFood = Console.ReadLine().ToString();
    
    if (pickFood == "Soup" || pickFood == "Stew" || pickFood == "Gumbo") return pickFood;

    else if (pickFood != "Soup" || pickFood != "Stew" || pickFood != "Gumbo") 
    {
        Food();
        return "";
    }
    else return pickFood;
}
string Ingredient()
{
    Console.WriteLine("What kind of Ingredient would you like?\nValid options are: Mushrooms, Chicken, Carrots and Potatoes");
    string? pickIngredient = Console.ReadLine().ToString();
    
    if (pickIngredient == "Mushrooms" || pickIngredient == "Chicken" || pickIngredient == "Carrots" || pickIngredient == "Potatoes") return pickIngredient;

    else if (pickIngredient != "Mushrooms" || pickIngredient != "Chicken" || pickIngredient != "Carrots" || pickIngredient != "Potatoes")
    {
        Food();
        return "";
    }
    else return pickIngredient;
}



