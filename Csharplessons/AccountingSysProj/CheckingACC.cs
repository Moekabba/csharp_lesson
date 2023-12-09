

namespace AccountingSysProj
{
    public class CheckingACC
    {
        // have my feilds here and premium acc with inheret this class
        public int ID { get; set; }
        public decimal Balance { get; set; }
       // public decimal startingBalance { get; set; }
       // public decimal depositAmunt { get; set; }

        public CheckingACC(int id, int startingbalance)
        {
            ID = id;
            Balance = startingbalance;
            //Console.WriteLine(Balance);
        }

        public void Deposit(decimal amount)
        {
            Balance += amount; // Balance will be increase by deposit amount so  Bal = amount

        }

        public  void Transfer(decimal amount,CheckingACC PremAcc)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                PremAcc.Deposit(amount);
            }
            else
            {
                Console.WriteLine("Too broke to transfer");
            }
        }
        public virtual decimal CalInterest(decimal interestRate)
        {
            return Balance * interestRate / 100; // calculate interest based on current

        }

    }
}
