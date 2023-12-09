

// Arguments are either :
// pass-by-value (default)
// pass-by-reference
// C# has value types (struct, int, bool,..) and reference types (classes)

// why strcut 
using System.Security.Cryptography.X509Certificates;

var human = new Human(200, 5.11); // obj of struct
Console.WriteLine($" Huamn height {human.Height}");

MethodParam.NewHeight(ref human);
Console.WriteLine($" new human height: {human.Height}");

var boy = new BoyClass( "Musa");
Console.WriteLine($"Boy Name : {boy.Name}");

MethodParam.ChangeName(boy);
Console.WriteLine($"Boy Name in method : {boy.Name}");


public class BoyClass
{
    public string Name { get; set; }
    public BoyClass(string name)
    {
        Name = name;
    }
}
public struct Human
{
    public Human(double width, double height)
    {
        Width = width;
        Height = height;
    }
    public double Width { get; set; }
    public double Height { get; set; }
}

public class MethodParam
{
    public static void ChangeName(BoyClass boy)
    {
        boy.Name = "unknow";
    }
    public static void NewHeight(ref Human newheight) // ref keyword changed this value type to ref type
    {
        newheight.Height = 6.4;
        Console.WriteLine($" new height in method: {newheight.Height}");
    }
}