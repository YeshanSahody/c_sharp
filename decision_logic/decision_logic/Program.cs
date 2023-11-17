Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1+roll2+roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if (total > 14)
{
    Console.WriteLine("You Win!!");
}else if (total < 15)
{
    Console.WriteLine("Sorry, you lose.");
}

string message = "The quick brown fox jumps over the lazy dog";
bool result = message.Contains("fox");
//Console.WriteLine(result);

if (result)
{
    Console.WriteLine("What does the dog do?");
}
else{
    Console.WriteLine("Where did the dog go?");
}

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
}