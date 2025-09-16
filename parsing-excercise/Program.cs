// set up the cost of the inventory items at the store
int swordCost = 55;
int shieldCost = 35;
// ...

Console.WriteLine("Hello dear patron, what is your name?");

string playerName = Console.ReadLine();

Console.WriteLine("How much gold do you have?");

string playerGoldResponse = Console.ReadLine();
int playerGold = int.Parse(playerGoldResponse);

Console.WriteLine($"A bronze sword costs {swordCost} gold.");

if (playerGold >= swordCost)
{
    playerGold -= swordCost;
    Console.WriteLine($"Congrats! You bought the bronze sword that you didn't even ask for. You now have {playerGold} gold left.");
}
else
{
    Console.WriteLine($"Sorry {playerName}, you do not have enough gold.");
}