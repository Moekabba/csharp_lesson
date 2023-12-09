// why strcut 
var human = new Human(200, 400); // obj of struct
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

// make this struct read 
//ImmuHuman immuhuman = new ImmuHuman(222, 343); // obj of struct
public readonly struct ImmuHuman
{
    public ImmuHuman(double width, double height)
    {
        Width = width;
        Height = height;
    }
    public double Width { get; init; }
    public double Height { get; init; }
}
