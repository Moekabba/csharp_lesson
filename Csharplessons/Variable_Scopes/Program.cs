// Variable scope types:
// Class level Scope, Method level Scope and Block level scope.

// code block only accesible in code 
int num = 4;
if (num >= 45 && num <= 57)
{
    //int num = 65;
    string generation = "Millenial";
    Console.WriteLine($" Your are a {generation} becuase you are {num} years old");

}
else
{
    string generation = "unkown";
    Console.WriteLine($" you're {generation}");
}