using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_interface2
{
    class PersonCurrent : BasicBankingInterface
    {
        int Balance;
        public bool deposit(int amount)
        {
            Balance += amount;
            Console.WriteLine("Deposit :" + amount);
            Console.WriteLine("Balance after Deposit:" + Balance);

            return true;
        }
        public bool withdraw(int amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine("Withdraw :" + amount);
                Console.WriteLine("Balance after Withdraw :" + Balance);
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
            return true;
        }
        public PersonCurrent(int Balance)
        {
            this.Balance = Balance;
            Console.WriteLine("Balance is:" + Balance);
        }
        
    }
}
