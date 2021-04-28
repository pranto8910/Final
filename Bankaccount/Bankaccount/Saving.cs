using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankaccount
{
    class Saving : Account
    {
        public Saving(string AccName, string AccNo, double balance) : base(AccName,AccNo,balance)
        {

        }
        public override void Transfer(Account acc, double amount)
        {
            if(amount <=Balance - 500)
            {
                Balance -= amount;
                acc.Balance += amount;
                Console.WriteLine("Account Transfer By {0} to the account {1} ({2})", amount, acc.AccName, acc.AccNo);
            }
            else
            {
                Console.WriteLine("Insufficient balance!");
            }
        }
        public override void Withdraw(double amount)
        {
            if (amount <= Balance -500)
            {
                Balance -= amount;
                Console.WriteLine("Account debited by {0} to self", amount);
            }
            else
            {
                Console.WriteLine("Insufficient balance!");
            }
        }
    }
}
