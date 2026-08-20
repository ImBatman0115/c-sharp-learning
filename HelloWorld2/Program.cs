//Dice roller version1
// Random dice = new Random();
// int roll = dice.Next(1,7);
// Console.WriteLine(roll);

//Dice roller version2 (example of overloaded methods)
// Random dice = new Random();
// int roll1 = dice.Next();
// int roll2 = dice.Next(101);
// int roll3 = dice.Next(50, 101);

// Console.WriteLine($"First roll: {roll1}");
// Console.WriteLine($"Second roll: {roll2}");
// Console.WriteLine($"Third roll: {roll3}");

//Math method challenge
// int firstValue = 500;
// int secondValue = 600;
// int largerValue = Math.Max(firstValue, secondValue);

// Console.WriteLine(largerValue);

//Dice rolling game! (intro to conditional statements)
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    Console.WriteLine("You rolled doubles! +2 bonus to your total! :o ");
    total +=2;
}

if((roll1 == roll2) && (roll2 == roll3))
{
    Console.WriteLine("You rolled triples! +6 bonus to total! :O ");
    total +=6;
}

if(total >= 15)
{
    Console.WriteLine("Your total is greater than 14! You Win!!! :) ");
}

if (total < 15)
{
    Console.WriteLine("Sorry, your total is less than 15. You lose. :( ");
}
