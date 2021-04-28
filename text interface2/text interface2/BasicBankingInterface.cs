using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_interface2
{
    public interface BasicBankingInterface
    {
        bool deposit(int amount);
        bool withdraw(int amount);
    }
}
