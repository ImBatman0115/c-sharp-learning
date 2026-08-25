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
// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//     Console.WriteLine("You rolled doubles! +2 bonus to your total! :o ");
//     total +=2;
// }

// if((roll1 == roll2) && (roll2 == roll3))
// {
//     Console.WriteLine("You rolled triples! +6 bonus to total! :O ");
//     total +=6;
// }

// if(total >= 15)
// {
//     Console.WriteLine("Your total is greater than 14! You Win!!! :) ");
// }

// if (total < 15)
// {
//     Console.WriteLine("Sorry, your total is less than 15. You lose. :( ");
// }

//Challenge: Improve renewal rate of subscriptions
// Random random = new Random();
// int daysUntilExpiration = random.Next(12);
// int discountPercentage = 0;

// if(daysUntilExpiration == 1)
// {
//     Console.WriteLine("Your subscription expires within a day!");
//     discountPercentage = 20;
//     Console.WriteLine($"Renew now and save {discountPercentage}%");

// } else if(daysUntilExpiration <= 5)
// {
// Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
//         discountPercentage = 10;
//         Console.WriteLine($"Renew now and save {discountPercentage}%");
// } else if(daysUntilExpiration <= 10)
// {
//      Console.WriteLine("Your subscription will expire soon. Renew now!");
// } else
// {
//     Console.WriteLine("nothing");
// }

//OPTIONAL:
// if (discountPercentage > 0)
// {
//     Console.WriteLine($"Renew now and save {discountPercentage}%");
// }

//ARRAYS!!
// string[] fraudulentOrderIDs = new string[3];
// fraudulentOrderIDs[0] = "A123";
// fraudulentOrderIDs[1] = "B456";
// fraudulentOrderIDs[2] = "C789";
//fraudulentOrderIDs[3] = "D000";

// string[] fraudulentOrderIDs = ["A123", "B456", "C789"];

// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// //reassigning values
// fraudulentOrderIDs[0] = "F000";
// Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

// //length property (will tell you how many items are in your array, starting at 1)
// Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

//USING LOOPS
// string[] names = ["Rowena", "Robin", "Bao"];
// foreach (string name in names)
// {
//     Console.WriteLine(name);
// }

// int[] inventory = [200, 450, 700, 175, 250];
// int sum = 0;
// int bin = 0;
// foreach (int items in inventory)
// {
//     sum += items;
//     bin++;
// Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
// }
// Console.WriteLine($"We have {sum} items in inventory");

//CHALLENGE: Report the order IDs that need further investigation
string[] fraudulentIDs = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];
foreach (string id in fraudulentIDs)
{
    if (id.StartsWith("B"))
    {
        Console.WriteLine($"{id}");
    }
}