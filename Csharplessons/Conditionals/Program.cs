// if condition 
// if statements allow us to have different paths in our application
int num = 5;

if (num == 4)
{
    Console.WriteLine("not the number");
}
else if (num == 5)
{
    Console.WriteLine("we got em");
}
else
{
    Console.WriteLine("I come when both conditions failed");
}

Console.WriteLine("I got executed after if code block");

// The Ternary Conditional operator

// [bool expersion]

int v = 3;
string pV = v == 4 ? "3.0" : "4.o"; // ? gives us a short-hand if-else situation
Console.WriteLine(pV);

// ============================Switch statement ===============
// useful when you have more than two outcome/ case

Console.WriteLine("Enter your age");
string ? input = Console.ReadLine();
int age = int.Parse(input);
//Console.WriteLine(input);

switch (age)
{
    case < 10:
        Console.WriteLine(" go to your momma");
        break;
    case < 21:
        Console.WriteLine("you can have beer, but not book a hotel");
        break;
    case < 30:
        Console.WriteLine("Need to get it together");
        break;
    case < 40:
        Console.WriteLine("Life will move fast");
        break;
    case < 50:
        Console.WriteLine("getting old fam");
        break;
    default:
        Console.WriteLine("you are old, young and wise");
        break;
}
