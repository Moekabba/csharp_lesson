
int[] myArr = new int[5];

myArr[0] = 1;
myArr[1] = 2;
myArr[2] = 3;
Console.WriteLine(myArr);
Console.WriteLine(myArr[1]);

// array intializer syntax
int[] myArr2 = new int[] {4, 8, 16, 20};
Console.WriteLine(myArr2);
Console.WriteLine(myArr2[1]);

// initialize with var keyword 
var myArr3 = new int[3];
myArr3[0] = 5;
myArr3[1] = 6;
myArr3[2] = 7;
Console.WriteLine(myArr3[2]);

// alternative array declaration
int[] myArr4 = { 11, 12, 4 };

// reference arrays 
Animal[] animals = new Animal[1];
animals[0] = new Animal("Monkey");

Console.WriteLine(animals);
var Animal = animals[0];
Console.WriteLine(Animal.Typee);
public class Animal
{
    public Animal(string type)
    {
        Typee = type;
    }
    public string Typee { get; set; }
}