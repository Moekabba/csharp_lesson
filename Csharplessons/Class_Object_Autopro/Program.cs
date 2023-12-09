
PersonAuto person1 = new PersonAuto("Musa");
PersonAuto person2 = new PersonAuto("Setou");



Console.WriteLine(person1.Name);
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
}