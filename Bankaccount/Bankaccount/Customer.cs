﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankaccount
{
    class Customer
    {
        public string Name { get; set; }
        Account[] accounts;
        public int Account;
        public Customer(string name)
        {
            Name = name;
            accounts = new Account[20];
        }
        public void AccDetails()
        {
            Console.WriteLine("Customer name:" + Name);
            for (int i=0; i< Account; i++)
            {
                accounts[i].ShowInfo();
            }
        }
        public void AddAccount(params Account[] accounts)
        {
            foreach (Account acc in accounts)
            {
                this.accounts[Account++] = acc;
            }
        }
        public Account findAccount(string accNo)
        {
            Account acc = null;
            for(int i=0;i<Account;i++)
            {
                if(accNo.Equals(accounts[i].AccNo))
                {
                    acc = accounts[i];
                    break;
                }
            }
            return acc;
        }
    }
}
