using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClass
{
    public abstract class BankAcc
    {
        public int accountNumber
        { get; set; }
        public List<string> accountHolderName = new List<string>();
        public DateTime accountOpeningDate
        { get; set; }
        public double balanceAmount
        { get; set; }
        public List<string> listofTransactions = new List<string>();
        public abstract void Debit(double Withdrawn);
        public void Credit(double Credited)
        {
            listofTransactions.Add("You Credited " + Credited + "rupees at " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            balanceAmount = balanceAmount + Credited;
        }
        public void CalculateBalanceAmount()
        {
            Console.WriteLine("remaining balance: " + balanceAmount);
        }
    }
}
