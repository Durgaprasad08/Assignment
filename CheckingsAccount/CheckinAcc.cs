using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankClass;

namespace CheckingsAccount
{
    public class CheckingsAcc : BankAcc
    {
        public override void Debit(double Withdrawn)
        {
            listofTransactions.Add("You Withdrawn " + Withdrawn + "rupees at " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            balanceAmount = balanceAmount - Withdrawn * 1.25;
        }
    }
}
