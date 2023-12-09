BankAccount acc1 = new BankAccount("Musa");
BankAccount acc2 = new BankAccount("LaMin", 44);

Console.WriteLine(acc1.Name);
Console.WriteLine(acc2.Name.ToLower());
public class BankAccount
{

    public int MoneyInAcc { get; set; }
    public string Name { get; set; }

    public BankAccount( string name)
    {
        MoneyInAcc = 0;
        Name = name;
    }

    public BankAccount(string name, int balance)
    {
        MoneyInAcc = balance;
        Name = name;

    }
}