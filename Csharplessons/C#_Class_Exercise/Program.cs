House houseObj = new House(2003, 45);
Console.WriteLine(houseObj.Year);
Console.WriteLine(houseObj.Size);
int BuiltYear = houseObj.HowOld();
Console.WriteLine($" the house was bulit in year: {BuiltYear} ");
class House
{
    // field use to save data in class. keep info in class
    //private int _year;
    //private int _size; // not in use when using autofield
   
    public House(int year, int size)
    {
        Year = year;
        Size = size;
        
    }

    // property makes feild acceesible and modifiy
    public int Year
    {
        get;  set;
    }

    public int Size
    {
        get; set;
    } 

    public int HowOld()
    {
        return Year;
       
    }

    public bool canbesold()
    {
        if (true)
        {
            Console.WriteLine("Yes this can be sold");
            return true;
        }
        


    }

}

//enhance it, redo it