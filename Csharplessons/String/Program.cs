string message = " Hello mf";
Console.WriteLine(message);

//empty string
string meptyMessage = string.Empty;
Console.WriteLine(meptyMessage);

string stringWithDoubleQuote = " this is a string with a double quote: \" ";
Console.WriteLine(stringWithDoubleQuote);

string filepath = "c:\\temp";
Console.WriteLine(filepath);

string filepath2 = @"c:\temp";
Console.WriteLine(filepath2);

//string length method
Console.WriteLine(filepath.Length);

// String concatenation
string firstName = "Fanta";
string lastName = "Fatty Kabba";
string fullName = firstName + " " + lastName;
Console.WriteLine(fullName);

// String interpolation
Console.WriteLine($" resut: {5 + 5}");