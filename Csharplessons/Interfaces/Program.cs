// now can finaly create instances of these classes that implemnt the IHuamn Interface
IHuman empl = new Employee();
IHuman empl2 = new ShiftSupervisor();

Console.WriteLine($"{empl.GetName()}: {empl.GetAge()}");
Console.WriteLine($"{empl2.GetName()}: {empl2.GetAge()} years old");

public interface IHuman
{
    // no method is implmented in an interfcae 
    // define method signature 
    string GetName();
    int GetAge();
    // these are method singature and every class that implement
    // this interfac most provide these two methods
}

public class Employee : IHuman
{
    public int GetAge()
    {
        return 45;
    }

    public string GetName()
    {
        return "James Bol";
    }
}

public class ShiftSupervisor : IHuman
{
    public int GetAge()
    {
        return 34;

    }

    public string GetName()
    {
        return "Hilton Rivera";
    }
}