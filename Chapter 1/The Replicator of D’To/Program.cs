// See https://aka.ms/new-console-template for more information
int[] numbers = new int[5];

Console.Write("Type your first number\n");
numbers[0] = Convert.ToInt32(Console.ReadLine());

Console.Write("Type your second number\n");
numbers[1] = Convert.ToInt32(Console.ReadLine());

Console.Write("Type your third number\n");
numbers[2] = Convert.ToInt32(Console.ReadLine());

Console.Write("Type your fourth number\n");
numbers[3] = Convert.ToInt32(Console.ReadLine());

Console.Write("Type your fifth number\n");
numbers[4] = Convert.ToInt32(Console.ReadLine());

int[] numerical = new int[5];

for (int number = 0; number < 5; number++)
{
    numerical[number] = numbers[number];
}

for (int number = 0; number < 5; number++)
{
    Console.WriteLine($"{numbers[number]} and {numerical[number]}");
}