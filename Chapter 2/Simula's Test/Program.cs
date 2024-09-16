ChestState chestStatus = ChestState.Locked;
while (true) 
{
    string chestText = ($"The chest's Status is {chestStatus}. What do you want to do? \nThe valid options are: unlock, lock, open and close");
    Console.WriteLine(chestText);
    string? input = Console.ReadLine();
    
    if (chestStatus == ChestState.Locked && input == "unlock") chestStatus = ChestState.Closed;
    if (chestStatus == ChestState.Locked && input == "open") Console.WriteLine("You can't open a locked chest without unlocking it first");
    if (chestStatus == ChestState.Closed && input == "open") chestStatus = ChestState.Open;
    if (chestStatus == ChestState.Closed && input == "lock") chestStatus = ChestState.Locked;
    if (chestStatus == ChestState.Open && input == "close") chestStatus = ChestState.Closed;

}

enum ChestState {Locked, Open, Closed};
