// boolan
bool enable =  false;
Console.WriteLine($"bool: {enable}");

enable = true;
Console.WriteLine($"bool: {enable}");

// char 
char c1 = 'a';
Console.WriteLine($"char: {c1}");

c1 = 'n';
Console.WriteLine($"char: {c1}");

//int
int a = 2;
int b = 30;
Console.WriteLine($"a: {a}, b: {b}");

// arithmetic operation use int
int multiply = a * b;
int divide  = b / a;
int add  = b + a;
int subtract  = a - b;
Console.WriteLine($"multiply: {multiply}, davide : {divide}, add: {add}, subtract: {subtract}");

//floating point numbers ==> always use the sufix of float point
float f = 3.5f; // float - single precision (32-bit) floating point number
double d = 8.7d; // double - double precision ( 64 - bit) floating point number
decimal dec = 7.15m; // decimal - high precision (128 - bit) smaller range floating p number
Console.WriteLine($"f: {f}, g: {d}, dec: {dec}");

// copy values 
int a1 = 7;
int a2 = 5;
a1 = 1;
Console.WriteLine($"a1: {a1}, a2: {a2}");

//nullable value allaws to assign null
int? i = null;
bool? i1 = null;

// const
//const int b1 = 10;
//Console.WriteLine($"conts value: {b1}");

// int l