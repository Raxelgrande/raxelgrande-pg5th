// See https://aka.ms/new-console-template for more information
int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int currentSmallest = int.MaxValue; // Start higher than anything in the array.

foreach (int value in array) 
{
    if (value < currentSmallest)
    currentSmallest = value;
}
Console.WriteLine(currentSmallest);

int[] arrayTwo = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int total = 0;
foreach (int value in arrayTwo) 
{
    total += value;
}
float average = (float)total / arrayTwo.Length;
Console.WriteLine(average);