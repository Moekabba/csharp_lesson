using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingSysProj
{
    public class PremAcc : CheckingACC
    {
        public PremAcc(int id, int startingbalance) : base(id, startingbalance)
        {
        }

        public override decimal CalInterest(decimal interestRate)
        {
            return base.CalInterest(interestRate + 1); // this acc gets 1% more interest
        }
    }
}
