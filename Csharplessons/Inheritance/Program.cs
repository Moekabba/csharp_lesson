Dog dogObj = new Dog("Benz");
Chiwawa ChiObj = new Chiwawa("linx", "Big");
public class Dog // sealed keyword class cant be inherited 
{
    public string Name { get; set; }

    public Dog(string name)
    {
        Name = name;
    }

    public string DogBreed() // adding virtual key word willow modification of this method in dervide class
    { return Name.ToUpper(); }
}

public class Chiwawa : Dog
{
    public string BigChiwaw ;
    public Chiwawa(string name, string big ) : base(name) 
    {
        BigChiwaw = big;
    
    }

}