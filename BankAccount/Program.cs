using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankClass;
using SavingsAccount;
using CheckingsAccount;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAcc Acc_savings = new SavingsAcc();
            Acc_savings.accountOpeningDate = DateTime.Now;
            Acc_savings.accountHolderName.Add("Bob");
            Acc_savings.accountHolderName.Add("Marley");
            Acc_savings.accountNumber = 10001;
            Acc_savings.Credit(500);
            Acc_savings.Debit(300);
            foreach (var value in Acc_savings.listofTransactions)
            {
                Console.WriteLine(value);
            }
            Acc_savings.CalculateBalanceAmount();
            CheckingsAcc Acc_Checkings = new CheckingsAcc();
            Acc_Checkings.accountOpeningDate = DateTime.Now;
            Acc_Checkings.accountHolderName.Add("Durga");
            Acc_Checkings.accountHolderName.Add("Prasad");
            Acc_Checkings.accountNumber = 100012;
            Acc_Checkings.Credit(1000);
            Acc_Checkings.Debit(300);
            foreach (var value in Acc_Checkings.listofTransactions)
            {
                Console.WriteLine(value);
            }
            Acc_Checkings.CalculateBalanceAmount();
        }
    }
}
