// persom class 

// we create object of this class (instance of class) .. use new key word to create object 
// new operator return reference of the created object

Person person1 = new Person();
Person person2 = new Person();

// ===== cant access _name so we made Name property
person1.Name = "Test";
Console.WriteLine(person1.Name);
class Person
{
    // this is a class

    // create private field 
    private string _name;

    // create a constructro
    public Person()
    {
        //use ctor = constructor is call when object of a class is being constructed
        _name = "Moe";
    }

    // the field _name is private and cant be access outside of person
    // create property to get around that
    public string Name
    {  
        get { return _name; } // allows us to grab
        set { _name = value; } // this allow us to change
    }
}

// === you can use auto property to archieve this 