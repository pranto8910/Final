using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankaccount
{
    class overdraft : Account
    {
        public int limit { get; set; }
        public overdraft()
        {

        }
        public overdraft(string accName,string accNo,double balance, int limit): base(accName,accNo,balance)
        {
            this.limit = limit;
        }
        public override void Transfer(Account acc,double amount)
        {
            if (amount<= Balance + limit)
            {
                Balance -= amount;
                acc.Balance += amount;
            }
            else
            {
                Console.WriteLine("No sufficient fund!");
            }
        }
        public override void Withdraw(double amount)
        {
            if(amount<=Balance+limit)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("No sufficient fund!");
            }
        }

    }
}
