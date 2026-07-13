// Console.WriteLine("Hello, World!");

// Console.WriteLine("Congratulations!");
// Console.Write(" ");
// Console.Write("You wrote your first lines of code!");

//WriteLine -> includes a line feed (appends a new line after the output)
// Write -> Puts text on one line, no line feed.

//Challenge: Write code the produces two lines of text
// Console.WriteLine("This is the first line.");
// Console.Write("This is the second line.");

//Character Literals
//Console.WriteLine('b');

//Integer Literals (no quotations)
// Console.WriteLine(123);

//Floating Point Literals
//Three data types for decimals: float(6-9 digits), double(15-17 digits), decimal(28-29 digits)
//Float
// Console.WriteLine(0.25F);
//Double
// Console.WriteLine(2.625);
//Decimal
// Console.WriteLine(12.39816m);

//Boolean Literals
// Console.WriteLine(true);
// Console.WriteLine(false);

//Declaring Variables!
// string firstName = "Bruce";
// Console.WriteLine(firstName);
// firstName = "Dick";
// Console.WriteLine(firstName);
// firstName = "Jason";
// Console.WriteLine(firstName);
// firstName = "Barbra";
// Console.WriteLine(firstName);

// var message = "Hi, ";
// Console.Write(message);
// Console.Write(firstName);

//Challenge: display literal and variable values
// var firstName = "Bruce";
// int amountOfMessages = 3;
// float temperature = 34.4f;

// Console.Write("Hello, ");
// Console.Write(firstName);
// Console.Write("! ");
// Console.Write("You have ");
// Console.Write(amountOfMessages);
// Console.Write(" messages in your inbox. The temperature is ");
// Console.Write(temperature);
// Console.Write(" celsius.");

//-----Adding a Package------

// using Humanizer;

// Console.WriteLine("Quantities:");
// HumanizeQuantities();

// Console.WriteLine("\nDate/Time Manipulation:");
// HumanizeDates();

// static void HumanizeQuantities()
// {
//     Console.WriteLine("case".ToQuantity(0));
//     Console.WriteLine("case".ToQuantity(1));
//     Console.WriteLine("case".ToQuantity(5));
// }

// static void HumanizeDates()
// {
//     Console.WriteLine(DateTime.UtcNow.AddHours(-24).Humanize());
//     Console.WriteLine(DateTime.UtcNow.AddHours(-2).Humanize());
//     Console.WriteLine(TimeSpan.FromDays(1).Humanize());
//     Console.WriteLine(TimeSpan.FromDays(16).Humanize());
// }

//-----Literal String Formatting and More-----

//Escape character sequence - instruction to runtime to insert a special character
// \n -> new line  \t -> new tab
// Console.WriteLine("Hello\nWorld");
// Console.WriteLine("Hello\tWorld");
// //example of double quotations
// Console.WriteLine("Hello \"World\"!");
// //example of file path
// Console.WriteLine("c:\\source\\repos");

// Console.WriteLine("\n");
// Console.WriteLine("Generating invoices for customer \"Contoso Corpz\" ...\n");
// Console.WriteLine("Invoice: 1021\t\tComplete!");
// Console.WriteLine("Invoice: 1022\t\tComplete!");
// Console.Write("\nOutput Directory:\t");
// //Verbatim string literal -- keeps all whitespace and characters without the need of escape backslash
// //To do so use "@" before the literal string like below
// //Console.WriteLine(@"    c:\source\repos
//             //(this is where your very cool code goes)");

// Console.Write(@"c:\invoices");

// //Unicode escape characters
// //Kon'nichiwa World
// //Console.WriteLine("\n\u3053\u3093\u306B\u3061\u306F World!");

// // To generate Japanese invoices:
// // Nihon no seikyū-sho o seisei suru ni wa:
// Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// // User command to run an application
// Console.WriteLine(@"c:\invoices\app.exe -j");

//-----Concatenation-----
// string firstName = "Bob";
// string greeting = "Hello ";
// Console.WriteLine(greeting + " " + firstName + "!");

//----Interpolation-----
// string firstName = "Kayden";
// string message = $"Hello {firstName}!";
// Console.WriteLine(message);

// int version = 11;
// string updateText = "Update to Windows";
// Console.WriteLine($"{updateText} {version}");

// string projectName = "First-Project";
// Console.WriteLine($@"C:\Output\{projectName}\Data");

//Challenge: Format and display instructions
// string projectName = "ACME";
// Console.WriteLine($"View English output:\n\t c:\\Exercise\\{projectName}\\data.txt");
// string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
// Console.WriteLine($"{russianMessage}:\n\t c:\\Exercise\\{projectName}\\ru-RU\\data.txt");

//----Numeric Manipulation----
//Concatenation:
// int firstNumber = 12;
// int secondNumber = 7;
// Console.WriteLine(firstNumber + secondNumber);

// string firstName = "Kayden";
// int widgetsSold = 7;
// Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");

//Mathematics:
// int sum = 7 + 5;
// int difference = 7 - 5;
// int product = 7 * 5;
// int quotient = 7 / 5;
// decimal decimalQuotient = 7.0m / 5;


// Console.WriteLine("Sum: " + sum);
// Console.WriteLine("Difference: " + difference);
// Console.WriteLine("Product: " + product);
// Console.WriteLine("Quotient: " + quotient);
// Console.WriteLine("Decimal Quotient: " + decimalQuotient);

// //Type cast - temporarily change the data type
// int first = 7;
// int second = 5;
// decimal castedQuotient = (decimal)first / (decimal)second;
// Console.WriteLine("Type Casted Quotient: " + castedQuotient);

//Modulus operator - is there an remainder to your division
// Console.WriteLine($"Modulus of 200 / 5: {200 % 5}");
// Console.WriteLine($"Modulus of 7 / 5: {7 % 5}");

//Order of Operations
// int value1 = 3 + 4 * 5;
// int value2 = (3 + 4) * 5;
// Console.WriteLine("Product of Value1: " + value1);
// Console.WriteLine("Product of Value2: " + value2);

//Increment and Decrement
// Console.WriteLine("------------------------------------------------");
//+= allows you to increment by a number you choose
// int value3 = 0;     // value is now 0.
// value3 = value3 + 5; // value is now 5. This line is the same as the line below
// value3 += 5;        // value is now 10. This line does it more efficiently

//++ allows you ti increment by 1
// int value4 = 0;     // value is now 0.
// value4 = value4 + 1; // value is now 1. This line is the same as the line below
// value4++;           // value is now 2. This line does it more efficiently

// int value = 1;

// value++;
// Console.WriteLine("First increment: " + value);

// Console.WriteLine("Second increment: " + value++);

// Console.WriteLine("Third increment: " + value);

// Console.WriteLine("Fourth increment: " + (++value));

// value = value - 1;
// Console.WriteLine("First decrement: " + value);

// value -= 1;
// Console.WriteLine("Second decrement: " + value);

// value--;
// Console.WriteLine("Third decrement: " + value);

//Challenge: Calculate Celsius given the current temperature in Fahrenheit
int fahrenheit = 94;
decimal celsius = (fahrenheit - 32m) * (5m / 9m);
Console.WriteLine($"The temperature is {celsius} Celsius");