// Define a loop that defines a variable 
for (int i = 0; i < 20; i++)
{
    //Console.WriteLine($"number of iterations: {i}");
}


// only prints values higher than 10 
for (int i = 0; i < 20; i++)
{
    if ( i > 10)
    {
        //Console.WriteLine($"These values are greater than 10: {i}");
    }
}

// Ask a user his age and print happy birthday on console
Console.WriteLine("Hi, What is your name?");
string nameInPut = Console.ReadLine();
Console.WriteLine($"Hello {nameInPut}, how old are you?");
string? useInput = Console.ReadLine();
// perse the strin
//int parsedUserInput = int.Parse(useInput);
// display input
Console.WriteLine($" Your name is {nameInPut}, and you're {useInput} years old");