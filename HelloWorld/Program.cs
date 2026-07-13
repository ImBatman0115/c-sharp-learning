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
string firstName = "Bob";
string message = "Hello " + firstName;
Console.WriteLine(message);
