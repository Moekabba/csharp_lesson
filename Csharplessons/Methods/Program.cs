
PersonAuto person1 = new PersonAuto("Musa");
PersonAuto person2 = new PersonAuto("Setou");
Math mathobj = new Math(); // Math obj
int result = mathobj.doMath(10, 30);
Console.WriteLine(result);

person1.PrintSomething();
// accessing return method
string Setou = person2.SaySomethingNice();
Console.WriteLine(Setou);

// accessin name from constructor
Console.WriteLine(person2.Name);
class PersonAuto
{


    // create a constructro
    public PersonAuto(string name) // alows to create pram
    {
        Name = name;
    }

    // 

    public string Name
    {
        get; set; // set set to private if you dont want it change
    }

    // methods, void = no return type
    public void PrintSomething()
    {
        Console.WriteLine($"Some thing to : {Name} ");
        // call method abouve
    }

    // method with return type
    public string SaySomethingNice()
    {
        return $"Hello {Name}, you have a beautiful smile  ";
    }
}

class Math
{
    public int doMath( int a, int b)
    {
        return a + b;
    }
}