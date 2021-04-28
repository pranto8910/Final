using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_interface2
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonCurrent p1 = new PersonCurrent(25000);
            Console.WriteLine("Corrent Account");
            p1.withdraw(2500);
            p1.deposit(3000);
            Console.WriteLine("___________________");

            Saving s1 = new Saving(25000);
            Console.WriteLine("Saving Account");
            s1.withdraw(2500);
            s1.deposit(3000);
            Console.WriteLine("___________________");

            Overdraft o1 = new Overdraft(25000);
            Console.WriteLine("Overdraft Account");
            o1.withdraw(2500);
            o1.deposit(3000);
            Console.WriteLine("___________________");
        }
    }
}
