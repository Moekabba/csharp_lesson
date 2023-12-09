// Implicit conversion: do nothing, no data loss, no precision loss
// Explicit conversion: casting, potential data loss, potential precision loss

int age = 27;
float weight = 15.5f;
Console.WriteLine($"age: {age}, weight: {weight}");

// example of implicit conversion int = long, no data los
long myAge = age;
Console.WriteLine($"age: {myAge}, weight: {weight}");

// explicit conversion 
int weightB  = (int)weight; // precission loss
int notMyAge  = (int)myAge; // no pression loss

long longNumber = 1111111111111111111;
int smallNumb = (int)longNumber; //data loss
Console.WriteLine(smallNumb);